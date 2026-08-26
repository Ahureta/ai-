using System.Text.RegularExpressions;
using static System.Formats.Asn1.AsnWriter;

namespace _8_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////敏感词替换
            //String s = "abcdefg";
            //String[] s1 = {"e" , "fg" };            
            //Array.Sort(s1,(a,b) => b.Length.CompareTo(a.Length));
            //foreach (String word in s1) {
            //    s = s.Replace(word, "**",StringComparison.OrdinalIgnoreCase);
            //}            
            //Console.WriteLine(s);


            //string str = "you love i";

            //// 分割 → 反转 → 每个单词首字母大写 → 拼接
            //string result = string.Join(" ",
            //    str.Split(' ')
            //       .Reverse()
            //       .Select(w => char.ToUpper(w[0]) + w.Substring(1).ToLower())
            //);

            //Console.WriteLine(result); // I Love You


            //反转字符串并首字符大写  
            //String str = "you love i";      
            //String str1 = "";
            //List<String>  str2 = str.Split().Reverse().ToList();
            //foreach (String item in str2) {
            //    String s3 = item.ToLower();
            //    String s4 = s3.Substring(0,1).ToUpper() + s3.Substring(1);
            //    str1+=s4+" ";
            //}
            //Console.WriteLine(str1);


            //-提取一句话中所有的中文姓名
            //String s = "zhong中二";
            //String reg = @"[\u4e00-\u9fa5]";
            //MatchCollection res = Regex.Matches(s,reg);
            //Console.WriteLine(String.Join(",",res));



            //- 替换所有多余空格
            //String s = "  i    lo c  ve  ";
            //String reg = @"\s+";
            //Console.WriteLine(Regex.Replace(s, reg," ").Trim());            


            //- 身份证号码
            //String s = "45090220050412345x";
            //String reg = @"[1-9][0-9]{16}[(1-9)|x|X]";
            //Console.WriteLine(Regex.Match(s, reg));



            //- 密码强度检测：强中弱（字母、数字、特殊符号）
            String password = "450912e./'.,asd'';";
            // 检测规则
            //int score = (Regex.IsMatch(password, @"[a-zA-Z]") ? 1 : 0)
            //          + (Regex.IsMatch(password, @"\d") ? 1 : 0)
            //          + (Regex.IsMatch(password, @"[^a-zA-Z0-9\s]") ? 1 : 0); // 非字母数字且非空白字符

            //string strength = password.Length >= 8
            //    ? (score == 3 ? "强" : score == 2 ? "中" : "弱")
            //    : "弱（长度不足）";

            //Console.WriteLine(strength);


        }
    }
}
