namespace 编程题3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = "";// 输入的操作编号
            EmployeeManager EM = new EmployeeManager();// 实例化员工管理对象
            while (num != "0")
            {
                Tips();  // 提示界面
                // 提示输入
                num = Console.ReadLine();
                string str = "";
                List<Employee> listEmployee = new List<Employee>();
                switch (num)
                {


                    case "1":
                        //员工编号、姓名、部门、薪资，自动创建员工对象
                        Console.WriteLine("请输入员工编号：");
                        string Id = Console.ReadLine();
                        Console.WriteLine("请输入员工姓名：");
                        string Name = Console.ReadLine();
                        Console.WriteLine("请输入员工部门：");
                        string Department = Console.ReadLine();
                        Console.WriteLine("请输入员工薪资：");
                        string Salary = Console.ReadLine();
                        if (double.TryParse(Salary, out double result))
                        {
                            Salary = result.ToString();
                        }
                        else
                        {
                            throw new ArgumentException("薪资必须为数字", nameof(Salary));
                        }
                        if (double.Parse(Salary) < 0) throw new ArgumentException("薪资不能为负数", nameof(Salary));

                        (str, _) = EM.Add(Id, Name, Department, Salary);
                        Console.WriteLine(str);
                        break;

                    case "2":
                        Console.WriteLine("查看所有员工信息");
                        (str, listEmployee) = EM.SearchAll();
                        Console.WriteLine(str);
                        CwEmployee(listEmployee);
                        break;

                    case "3":
                        Console.WriteLine("请输入员工ID");
                        int EditId = int.Parse(Console.ReadLine());
                        str = EM.EditEmployee(EditId);
                        Console.WriteLine(str);
                        CwEmployee(listEmployee);
                        break;

                    case "4":
                        Console.WriteLine("4：根据编号删除员工（删）");
                        Console.WriteLine("请输入员工ID");
                        int removeId = int.Parse(Console.ReadLine());

                        str = EM.RemoveEmployee(removeId);
                        Console.WriteLine(str);
                        break;

                    case "5":
                        Console.WriteLine("按薪资条件筛选员工（查-条件）");
                        Console.WriteLine("请输入薪资：");
                        double salary = double.Parse(Console.ReadLine());

                        (str, listEmployee) = EM.SearchBySalary(salary);
                        Console.WriteLine(str);
                        CwEmployee(listEmployee);
                        break;

                    case "6":
                        Console.WriteLine("退出系统");
                        break;

                    default:
                        Console.WriteLine("输入编号有误，请重新输入！！！");
                        break;
                }
                Console.WriteLine();
            }
        }

            public static void CwEmployee(Employee employee)
            {                
                Console.WriteLine(employee.EmpId + "\t" +
                    employee.EmpName + "\t" +
                    employee.Department + "\t" +
                    employee.Salary
                );
            }

            public static void CwEmployee(List<Employee> listEmployee)
            {
                foreach (Employee item in listEmployee)
                    Console.WriteLine(item.EmpId + "\t" +
                        item.EmpName + "\t" + 
                        item.Department + "\t" +
                        item.Salary
                    );
            }

            static void Tips()
            {
                // 提示界面
                Console.WriteLine("==欢迎来到员工薪资管理控制台系统==");
                Console.WriteLine("请选择操作编号：");                
                Console.WriteLine("1：新增员工（增）");
                Console.WriteLine("2：查看全部员工（查-全部）");
                Console.WriteLine("3：根据编号调整薪资（改）");
                Console.WriteLine("4：根据编号删除员工（删）");                
                Console.WriteLine("5：按薪资条件筛选员工（查-条件）");
                Console.WriteLine("6：退出系统");
            }        
    }
}
