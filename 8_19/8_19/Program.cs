using _8_19;
using System.Diagnostics;

namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = "";// 输入的操作编号
            CarManager CM = new CarManager();// 实例化车辆管理对象

            while (num != "0")
            {

                Tips();  // 提示界面
                // 提示输入
                num = Console.ReadLine();
                string str = "";
                List<Vehicle> list = new List<Vehicle>();
                switch (num)
                {
                    case "0":
                        Console.WriteLine("退出系统");
                        break;

                    case "1":
                        // 车辆输入
                        Console.WriteLine("请输入车类型：");
                        string Type = Console.ReadLine();
                        Console.WriteLine("请输入时租费：");
                        string Price = Console.ReadLine();
                        (str, _) = CM.Add(Type, Price);
                        Console.WriteLine(str);
                        break;

                    case "2":
                        Console.WriteLine("查看所有车辆信息");
                        (_, list) = CM.SearchAll();
                        cwStr(list);
                        break;

                    case "3":
                        Console.WriteLine("请输入车辆ID");
                        int id = int.Parse(Console.ReadLine());
                        (str, _) = CM.SearchOne(id);
                        Console.WriteLine(str);
                        break;

                    case "4":
                        CM.SearchFree();
                        //(str, _) = CM.SearchAll();
                        //Console.WriteLine(str);
                        break;

                    case "5":
                        Console.WriteLine("新增客户");
                        //(str, _) = CM.SearchAll();
                        //Console.WriteLine(str);
                        break;

                    case "6":
                        Console.WriteLine("查看所有客户");
                        //(str, _) = CM.SearchAll();
                        //Console.WriteLine(str);
                        break;

                    case "7":
                        Console.WriteLine("查看某个客户");
                        //(str, _) = CM.SearchAll();
                        //Console.WriteLine(str);
                        break;

                    case "8":
                        Console.WriteLine("租车");
                        //(str, _) = CM.SearchAll();
                        //Console.WriteLine(str);
                        break;

                    case "9":
                        Console.WriteLine("还车");
                        //(str, _) = CM.SearchAll();
                        //Console.WriteLine(str);
                        break;

                    default:
                        Console.WriteLine("输入编号有误，请重新输入！！！");
                        break;
                }
                Console.WriteLine();
            }
        }

        public static void cwStr(List<Vehicle> list) 
        {
            Console.WriteLine(string.Join(", ", list));
        }

        static void Tips()
        {
            // 提示界面
            Console.WriteLine("==欢迎来到神车系统==");
            Console.WriteLine("请选择操作编号：");
            Console.WriteLine("0：退出系统");
            Console.WriteLine("1：新增车辆");
            Console.WriteLine("2：查看所有车辆信息");
            Console.WriteLine("3：查看某辆车");
            Console.WriteLine("4：查看所有空闲车辆");

            Console.WriteLine("5：新增客户");
            Console.WriteLine("6：查看所有客户");
            Console.WriteLine("7：查看某个客户");
            Console.WriteLine("8：租车");
            Console.WriteLine("9：换车");
        }
    }
}
