using System.Text.RegularExpressions;

namespace 编程题2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //• 定义一个字符串数组，存储5个任意字符串（包含手机号、普通文本）；
            //• 使用字符串方法去除每个字符串的前后空格，将所有字母转换为小写；
            //• 使用正则表达式判断每个字符串是否为合法手机号（11位数字，以13、14、15、17、18开头）；
            //通过条件语句区分并打印：合法手机号、非法手机号、普通文本。
            string[] strings = { "1376WssUU", "   14567890987   ", "15344566111", "17999876789", "18009875467" };
            string[] newStr = new string[5];
            for (int i=0;i<5;i++) 
            {
                newStr[i] = strings[i].Trim().ToLower();
            }

            string reg = @"^[13|14|15|17|18]\d{10}$";       //奇怪,明明{9}才对,但是{10}才是正确的
            string reg1 = @"[^\d]+";
            Regex regex = new Regex(reg);
            Regex regex1 = new Regex(reg1);
            for (int j = 0; j < 5; j++)
            {
                if (regex1.IsMatch(newStr[j]))
                {
                    Console.WriteLine($"{newStr[j]} 是普通文本");
                }
                else 
                {
                    if (regex.IsMatch(newStr[j]))
                    {
                        Console.WriteLine($"{newStr[j]} 是合法手机号");
                    }
                    else
                    {
                        Console.WriteLine($"{newStr[j]} 不是合法手机号");
                    }
                }
            }
        }
    }
}
