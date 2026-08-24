using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_19.Tools
{
    using System;

    public static class InputHelper
    {
        /// <summary>
        /// 循环读取一个 int，直到输入合法
        /// </summary>
        public static int ReadInt(string prompt, string errorMsg = "❌ 请输入有效的整数：")
        {
            Console.Write(prompt);
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                    return result;
                Console.Write(errorMsg);
            }
        }

        /// <summary>
        /// 循环读取一个 int，且限定最小值（比如 id > 0）
        /// </summary>
        public static int ReadInt(string prompt, int minValue, string errorMsg = null)
        {
            Console.Write(prompt);
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int result) && result >= minValue)
                    return result;
                Console.Write(errorMsg ?? $"❌ 请输入大于等于 {minValue} 的整数：");
            }
        }

        /// <summary>
        /// 循环读取一个 double（用于薪资/价格）
        /// </summary>
        public static double ReadDouble(string prompt, double minValue = 0, string errorMsg = null)
        {
            Console.Write(prompt);
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double result) && result >= minValue)
                    return result;
                Console.Write(errorMsg ?? $"❌ 请输入大于等于 {minValue} 的有效数字：");
            }
        }

        /// <summary>
        /// 循环读取非空字符串
        /// </summary>
        public static string ReadNonEmpty(string prompt, string errorMsg = "❌ 输入不能为空，请重新输入：")
        {
            Console.Write(prompt);
            while (true)
            {
                string? input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    return input;
                Console.Write(errorMsg);
            }
        }
    }
}
