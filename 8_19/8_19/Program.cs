using _8_19;
using _8_19.info;
using _8_19.info.user;
using _8_19.Manager;
using System.Diagnostics;
using System.Numerics;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = "";// 输入的操作编号
            CarManager CM = new CarManager();// 实例化车辆管理对象
            UserManager UM = new UserManager();// 实例化用户管理对象
            RecordManager RM = new RecordManager();// 实例化记录管理对象
            while (num != "0")
            {

                Tips();  // 提示界面
                // 提示输入
                num = Console.ReadLine();
                string str = "";
                List<Vehicle> listVehicle = new List<Vehicle>();
                List<User> listUser = new List<User>();
                List<Record> listRecord = new List<Record>();
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
                        (str, listVehicle) = CM.SearchAll();
                        Console.WriteLine(str);
                        CwVehicle(listVehicle);
                        break;

                    case "3":
                        Console.WriteLine("请输入车辆ID");
                        int carId = int.Parse(Console.ReadLine());
                        (str, listVehicle) = CM.SearchOne(carId);
                        Console.WriteLine(str);
                        CwVehicle(listVehicle);
                        break;

                    case "4":
                        Console.WriteLine("4：查看所有空闲车辆");
                        (str, listVehicle) = CM.SearchFree();
                        Console.WriteLine(str);
                        CwVehicle(listVehicle);
                        break;

                    case "5":
                        Console.WriteLine("新增客户");
                        Console.WriteLine("请输入客户姓名：");
                        string Name = Console.ReadLine();

                        Console.WriteLine("请输入身份证号：");
                        string Number = Console.ReadLine();

                        Console.WriteLine("请输入性别：");
                        string Gander = Console.ReadLine();
                        
                        Console.WriteLine("请输入手机号：");
                        string Phone = Console.ReadLine();

                        Console.WriteLine("请输入座右铭：");
                        string Motto = Console.ReadLine();
                        
                        string RegTime = DateTime.UtcNow.ToString();

                        User user = new(Name,Number,RegTime,Gander,Phone,Motto);
                        
                        (str, _) = UM.Add(user);
                        Console.WriteLine(str);
                        break;

                    case "6":
                        Console.WriteLine("查看所有客户");
                        (str, listUser) = UM.SearchAll();
                        Console.WriteLine(str);
                        CwUser(listUser);
                        break;

                    case "7":
                        Console.WriteLine("查看某个客户");
                        Console.WriteLine("请输入id：");
                        int.TryParse(Console.ReadLine(), out int userId);                        
                        (str, User userOne) = UM.SearchOne(userId);
                        Console.WriteLine(str);
                        CwUser(userOne);
                        break;

                    case "8":
                        Console.WriteLine("租车");
                        Console.WriteLine("请输入车辆ID：");
                        int.TryParse(Console.ReadLine(), out int vehicleId);
                        Console.WriteLine("请输入用户ID：");
                        int.TryParse(Console.ReadLine(), out int userId2);
                        (str, _) = RM.lease(vehicleId, userId2);
                        Console.WriteLine(str);
                        break;

                    case "9":
                        Console.WriteLine("还车");
                        Console.WriteLine("请输入车辆ID：");
                        int.TryParse(Console.ReadLine(), out int vehicleId2);
                        (str, _) = RM.ret(vehicleId2);
                        Console.WriteLine(str);
                        break;

                    default:
                        Console.WriteLine("输入编号有误，请重新输入！！！");
                        break;
                }
                Console.WriteLine();
            }
        }

        public static void CwUser(User user)
        {            
                Console.WriteLine(user.Id + "\t" +
                    user.Name + "\t" +
                    user.Number + "\t" +
                    user.RegTime + "\t" +
                    user.Gander + "\t" +
                    user.Phone + "\t" +
                    user.Motto
                );
        }

        public static void CwUser(List<User> listUser)
        {
            foreach (User item in listUser)
                Console.WriteLine(item.Id + "\t" +
                    item.Name + "\t" +
                    item.Number + "\t" +
                    item.RegTime + "\t" +
                    item.Gander + "\t" +
                    item.Phone + "\t" +
                    item.Motto
                );
        }

        public static void CwVehicle(List<Vehicle> listVehicle)
        {
            foreach (Vehicle item in listVehicle)
                Console.WriteLine(item.Id +"\t"+
                    item.Type + "\t" +
                    item.Number + "\t" +
                    item.Status + "\t" +
                    item.Price
                );
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
            Console.WriteLine();
            Console.WriteLine("5：新增客户");
            Console.WriteLine("6：查看所有客户");
            Console.WriteLine("7：查看某个客户");
            Console.WriteLine();
            Console.WriteLine("8：租车");
            Console.WriteLine("9：还车");
        }
    }
}
