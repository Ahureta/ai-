using System.Runtime.Intrinsics.X86;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 5.0;
            double y = 8.0;
            double z = x + y;
            Console.WriteLine("第一题:" + z);
            double she;
            double hua = 80;
            Console.WriteLine("第二题:" + du(hua).ToString("F3"));
            change((int)x, (int)y);
            tian(89);
            //Console.WriteLine(int.Parse("a"));
            Console.WriteLine("++:运算" + (++x));
            int n = 10;
            int res = n++ + ++n + n++ + ++n;
            Console.WriteLine(res);

        }
        public static double du(double x)
        {
            return 5 / 9.0 * (x - 32);
        }
        public static void change(int x,int y)
        {
            Console.WriteLine("第三题: \n交换前:x={0} y={1}", x, y);
            int c = x;
            x = y;
            y = c;
            Console.WriteLine("交换后: x={0} y={1}",x,y);
        }
        public static void tian(int x)
        {            
            int hous = x % 24; 
            Console.WriteLine("第四题: {0}天,{1}小时", (int)(x/24), hous);
        }
    }
}
