using _8_19.Info;
using _8_19.Info.User;
using _8_19.Info.Car;
using _8_19.Manager;
using _8_19.Tools;
using System.Diagnostics;
using System.Numerics;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _8_19
{
    internal class Program
    {
        /*
        1. 将阶段考试项目代码自己写一遍
        2. 将其中重复的代码 封装
        3. 添加校验
            - id： int  
            - 薪资： double
        */
        static void Main(string[] args)
        {
            string num = "";// 输入的操作编号
            VehicleManager CM = new VehicleManager();// 实例化车辆管理对象
            UserManager UM = new UserManager();// 实例化用户管理对象
            RecordManager RM = new RecordManager();// 实例化记录管理对象
            List<Vehicle> listVehicle;
            List<User> listUser;
            List<Record> listRecord;
            while (num != "0")
            {

                Tips();  // 提示界面
                // 提示输入
                num = Console.ReadLine();
                string str = "";
                switch (num)
                {
                    case "0":
                        Console.WriteLine("退出系统");
                        break;

                    case "1":
                        // 新增车辆
                        CM.SearchAllVehicleTypes();
                        string type = InputHelper.ReadNonEmpty("请输入车类型：");
                        double price = InputHelper.ReadDouble("请输入时租费（数字）：", minValue: 0);
                        (str, _) = CM.Add(type, price.ToString());
                        Console.WriteLine(str);
                        break;

                    case "3":
                        // 查看某辆车
                        int carId = InputHelper.ReadInt("请输入车辆ID：", minValue: 1);
                        (str, listVehicle) = CM.SearchOne(carId);
                        Console.WriteLine(str);
                        CwVehicle(listVehicle);
                        break;

                    case "5":
                        // 新增客户
                        string name = InputHelper.ReadNonEmpty("请输入客户姓名：");
                        string number = InputHelper.ReadNonEmpty("请输入身份证号：");
                        string gander = InputHelper.ReadNonEmpty("请输入性别：");
                        string phone = InputHelper.ReadNonEmpty("请输入手机号：");
                        string motto = InputHelper.ReadNonEmpty("请输入座右铭：");
                        string regTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        User user = new User(name, number, regTime, gander, phone, motto);
                        (str, _) = UM.Add(user);
                        Console.WriteLine(str);
                        break;

                    case "7":
                        // 查看某个客户
                        int userId = InputHelper.ReadInt("请输入客户ID：", minValue: 1);
                        (str, User userOne) = UM.SearchOne(userId);
                        Console.WriteLine(str);
                        CwUser(userOne);
                        break;

                    case "8":
                        // 租车
                        int vehicleId = InputHelper.ReadInt("请输入车辆ID：", minValue: 1);
                        int userId2 = InputHelper.ReadInt("请输入用户ID：", minValue: 1);
                        (str, _) = RM.lease(vehicleId, userId2);
                        Console.WriteLine(str);
                        break;



                    case "2":
                        Console.WriteLine("查看所有车辆信息");
                        (str, listVehicle) = CM.SearchAll();
                        Console.WriteLine(str);
                        CwVehicle(listVehicle);
                        break;



                    case "4":
                        Console.WriteLine("4：查看所有空闲车辆");
                        (str, listVehicle) = CM.SearchFree();
                        Console.WriteLine(str);
                        CwVehicle(listVehicle);
                        break;


                    case "6":
                        Console.WriteLine("查看所有客户");
                        (str, listUser) = UM.SearchAll();
                        Console.WriteLine(str);
                        CwUser(listUser);
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
