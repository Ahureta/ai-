using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _8_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，" +
            //    "渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            //string salt = "7-16-30-38-49-52-63-70";
            //string result = ""; // 最终获取到的情报
            //string[] s = salt.Split("-");
            //foreach (string item in s)
            //{
            //    if (int.TryParse(item, out int index))
            //    {
            //        // 确保索引在合法范围内
            //        if (index >= 0 && index < text.Length)
            //        {
            //            result += text[index];
            //        }
            //    }
            //}
            //Console.WriteLine(result);

            //通过情报内容获取到下标：
            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            //string salt = "午夜渡口交换情报";
            //List<int> nums = []; // 创建一个list 用于未来的密文索引存储
            //foreach (char item in salt)
            //{
            //    nums.Add(text.IndexOf(item));
            //}
            //String s = String.Join("-", nums);
            //Console.WriteLine(s);


            //int money = 1002300456;
            //string str = money.ToString();
            //// 0    1    2   3   4  。。。
            //// 零   壹   贰  叁  肆
            //// 对应关系：数字当作下标，从下面的集合中用下标获取汉字
            //// 创建汉字数组
            //string[] arr = new string[] {
            //    "零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖"
            //};
            //// 创建单位数组
            //string[] units = new string[] {
            //    "", "拾", "佰", "仟", "萬", "拾", "佰", "仟", "亿", "拾", "佰", "仟"
            //};
            //string result = "";

            //for (int i = 0; i < str.Length; i++)
            //{
            //    int.TryParse(str[i].ToString(), out int moneyInt);    
            //    if(arr[moneyInt] != "零")result = result + arr[moneyInt] + units[str.Length - 1 - i];
            //}

            //// 零亿 => 亿   零零亿=>亿 零零零亿=>亿
            //result = Regex.Replace(result, @"零+亿", "亿");
            //// 零万 => 万   零零万=>万 零零零万=>万
            //result = Regex.Replace(result, @"零+萬", "萬");
            //// 多个零都换成一个零
            //result = Regex.Replace(result, @"零+", "零");
            //// 结尾是零的判断
            //if (result.EndsWith("零"))
            //{
            //    // 将零截取掉
            //    result = result.Substring(0, result.Length - 1);
            //}
            //Console.WriteLine(result);
            // 有缺陷,难补,用四位一节吧


            // 将数字按四位一节分组，从低位开始
            //List<string> sections = new List<string>();
            //for (int i = len; i > 0; i -= 4)
            //{
            //    int start = Math.Max(0, i - 4);
            //    int length = i - start;
            //    string section = numStr.Substring(start, length);
            //    sections.Add(section);
            //}

            string[] Digits = { "零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖" };
            // 每节内的单位（从低位到高位）
            string[] SectionUnits = { "", "拾", "佰", "仟" };
            // 节单位（从低位到高位）
            string[] LevelUnits = { "", "万", "亿", "万亿" };


            int money = 1002300456;//1,002,300,456;

            string numStr = money.ToString();
            int len = numStr.Length;

            //将数字按四位一节分组，从低位开始
            List<string> sections = new List<string>();
            for (int i = len; i > 0; i -= 4)
            {
                int start = Math.Max(0, i - 4);
                int length = i - start;
                string section = numStr.Substring(start, length);
                sections.Add(section);
            }

            StringBuilder result = new StringBuilder();
            bool needZero = false; // 标记是否需要在高位节前补零

            // 从最高节开始遍历（倒序）
            for (int level = sections.Count - 1; level >= 0; level--)
            {
                string section = sections[level];
                string sectionChinese = ConvertSection(section, Digits, SectionUnits, out bool hasZeroInside);

                if (!string.IsNullOrEmpty(sectionChinese))
                {
                    // 如果前一个节全为零且当前节不是最高节，需要补一个“零”
                    if (needZero && level < sections.Count - 1)
                    {
                        result.Append("零");
                    }
                    result.Append(sectionChinese);
                    result.Append(LevelUnits[level]); // 添加节单位（万、亿等）
                    needZero = false;
                }
                else
                {
                    // 当前节全为零
                    if (level > 0) // 不是最低位（个位节）
                    {
                        needZero = true; // 标记需要补零，但不立即添加
                    }
                }

                // 如果当前节内部有零，也可能导致下一节需要补零
                if (hasZeroInside)
                {
                    needZero = true;
                }
                Console.WriteLine(result);
            }
        }

        static string ConvertSection(string section, string[] digits, string[] sectionUnits, out bool hasZero)
        {
            hasZero = false;
            if (string.IsNullOrEmpty(section)) return "";

            int len = section.Length;
            StringBuilder sb = new StringBuilder();
            bool zeroFlag = false; // 是否遇到了零但尚未输出

            for (int i = 0; i < len; i++)
            {
                int digit = section[i] - '0';
                int unitIndex = len - 1 - i; // 从高位到低位的单位索引

                if (digit == 0)
                {
                    zeroFlag = true; // 标记遇到零，但先不输出
                }
                else
                {
                    // 如果之前有零标记，先输出一个“零”
                    if (zeroFlag)
                    {
                        sb.Append("零");
                        zeroFlag = false;
                        hasZero = true;
                    }
                    sb.Append(digits[digit]);
                    sb.Append(sectionUnits[unitIndex]);
                }
            }

            // 如果整个节全是零，返回空字符串（调用方会处理）
            if (sb.Length == 0)
                return "";

            return sb.ToString();

        }
    }
}
