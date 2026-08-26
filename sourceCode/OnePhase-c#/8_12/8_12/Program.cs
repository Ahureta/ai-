namespace _8_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //用函数封装一个猜数字的小游戏，函数中生成一个随机整数（0 - 100）作为目标数字，
            //    不停的让用户输入数字，距离目标数字偏大，就提示用户偏大，距离目标数字偏小就输出偏小，
            //    用户有5次输入的机会，5次没有猜对，输出GAME OVER，猜对了就输出WIN！


            //void print() {
            //    Random random = new Random();
            //    int b = random.Next(0, 10);
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.WriteLine("请输入一个数字");
            //        int a = 0;
            //        while (!int.TryParse(Console.ReadLine(), out a))
            //        {
            //            Console.WriteLine("输入有误,请重新输入:");
            //        }
            //        if (a == b)
            //        {
            //            Console.WriteLine("对了");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine((a > b) ? "大了" : "小了");
            //        }

            //    }                
            //}
            //print();



            ////1.装修房间：参数1，圆的半径，计算圆的面积，每平方米收费200元，返回装修总价。计算这个半径的圆装修一半需要多少钱？
            //Console.WriteLine((0.5 * money(1)).ToString("f2")+"元");
            //double money(double r) {
            //    return Math.PI*Math.Pow(r,2)*200;
            //}


            ////2.计算字符在字符串中出现的次数：参数1字符串，参数2某个字符，函数统计次数，并返回。
            //string str = "1234567890123";
            //string s = "123";
            //Console.WriteLine(count(str,s));
            //int count(string str,string s) {
            //    int count1 = 0;
            //    int index = 0;
            //    while ((index = str.IndexOf(s,index)) != -1){                    
            //        count1++;
            //        index += s.Length;
            //    }
            //    return count1;
            //}


            ////3.计算一个整型数组中，最小值第一次出现的下标。            
            //int[] ints = [55, 33, 11, 5, 2123, 668, 3, 557, 34, 445, 3, 22, 77, 6, 1];
            //int min = ints.Min();                 // 获取最小值
            //int minIndex = Array.IndexOf(ints, min); // 获取第一次出现的索引
            //Console.WriteLine($"最小值 {min} 第一次出现的下标是 {minIndex}");


            ////4.判断一个字符串是否为回文，返回布尔值类型。
            //string s1 = "abcdfdcba";
            //Console.WriteLine(r(s1));
            //bool r (string s) {
            //    char[] chars = s.ToCharArray();
            //    Array.Reverse(chars);
            //    return s == new string(chars);
            //}
            
        }
    }
}
