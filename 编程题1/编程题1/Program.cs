using System.Text.Json;

namespace 编程题1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //• 使用Random类生成10个1 - 50之间的随机整数，存储到数组中；
            //• 通过循环语句遍历数组，计算这10个随机数的总和和平均值；
            //• 将数组中的所有元素、总和、平均值打印到控制台。
            Random ran = new Random();
            int[] arr = new int[10];
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                arr[i] = ran.Next(1, 51); // Next(1, 51) 生成1-50之间的随机数（包含1，包含50）
                sum += arr[i];
            }
            double avg = sum / 10.0;

            Console.WriteLine("数组元素: " + string.Join(", ", arr));
            Console.WriteLine("总和: " + sum);
            Console.WriteLine("平均值: " + avg);
        }
    }
}
