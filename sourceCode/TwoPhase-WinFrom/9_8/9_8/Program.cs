using System.Runtime.InteropServices;

namespace _9_8
{
    //delegate void asg();
    internal class Program
    {
        //[DllImport("kernel32.dll")]
        //public static extern bool AllocConsole();
        //delegate void asg();
        static void Main(string[] args)
        {
            //AllocConsole();
            int c;
            int n = 7;
            //从第3个开始
            (_, _, c, n) = fn(1,1,0,n-2);
            Console.WriteLine("第n个:" + c);
        }
        static (int, int, int, int) fn(int a,int b,int c,int n) {
            if (n-- == 0) return (a, b, c, n);
            c = a + b;
            a = b;b = c;
            return fn(a,b,c,n);
        }
    }
}
