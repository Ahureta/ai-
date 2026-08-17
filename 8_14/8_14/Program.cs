using System.Text.Json;

namespace _8_14
{
    internal class Program
    {
        // 修复：将 static readonly 字段声明移到这里
        static readonly string userFilePath = "./user.json";
        static readonly string logFilePath = "./user.log";

        static void Main(string[] args)
        {
            //var a = (1, 0); // 示例：二元组
            // 或者
            // var a = ValueTuple.Create(1); // 单元素元组   
            //var aa = new ValueTuple<int>(1);

            //书写函数 实现写入日志操作, 日志内容: 输入内容 + 日期
            //string userPath = @"./user.text";
            //string passwordPath = @"./password.text";
            //string r = @"./r.log";
            //File.AppendAllText(r, "输入内容:" + System.DateTime.Now + "\n");
            //Func<string, List<string>> getFilesAndDir = (path) =>
            //{
            //    if (Directory.Exists(path) == false) throw new Exception("输入有误");
            //    List<string> filesAndDir = new List<string>();
            //    filesAndDir.AddRange(Directory.GetDirectories(path));
            //    filesAndDir.AddRange(Directory.GetFiles(path));
            //    return filesAndDir;
            //};

            //Console.WriteLine(string.Join("-", getFilesAndDir("./")));


            //作业: 使用读写文件配合命令行窗口 模拟实现注册功能
            //要求输入用户名和密码,完成注册; (注册的用户信息记录在user.txt文件中, 一行一个用户信息 数据之间通过 === 分隔)

            // 初始化用户文件（如果不存在则创建空数组）
            if (!File.Exists(userFilePath))
                File.WriteAllText(userFilePath, "[]");

            while (true)
            {
                Console.WriteLine("===== 菜单栏 =====");
                Console.WriteLine("1. 注册");
                Console.WriteLine("2. 登录");
                Console.WriteLine("0. 退出");
                Console.Write("请选择: ");
                string choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            Register();
                            break;
                        case "2":
                            Login();
                            break;
                        case "0":
                            LogOperation("退出", "系统", "退出程序");
                            Console.WriteLine("再见！");
                            return;
                        default:
                            Console.WriteLine("输入有误，请重新输入。");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    LogOperation("异常", "系统", $"发生异常: {ex.Message}");
                    Console.WriteLine($"系统错误: {ex.Message}");
                }
            }
        }

        static void Register()
        {
            Console.WriteLine("===== 注册 =====");
            string username = GetNonEmptyInput("请输入用户名: ");
            string password = GetNonEmptyInput("请输入密码: ");

            // 读取已有用户列表
            var users = LoadUsers();

            // 检查用户名是否已存在
            if (users.Any(u => u.username == username))
            {
                Console.WriteLine("用户名已存在，注册失败。");
                LogOperation("注册失败", username, "用户名已存在");
                return;
            }

            // 添加新用户
            users.Add(new User
            {
                username = username,
                password = password,
                datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            });

            // 保存到文件
            SaveUsers(users);
            LogOperation("注册成功", username, "");
            Console.WriteLine("注册成功！");
        }

        static void Login()
        {
            Console.WriteLine("===== 登录 =====");
            string username = GetNonEmptyInput("请输入用户名: ");
            string password = GetNonEmptyInput("请输入密码: ");

            var users = LoadUsers();
            var user = users.FirstOrDefault(u => u.username == username && u.password == password);

            if (user != null)
            {
                LogOperation("登录成功", username, "");
                Console.WriteLine("登录成功！欢迎回来。");
            }
            else
            {
                LogOperation("登录失败", username, "用户名或密码错误");
                Console.WriteLine("用户名或密码错误，登录失败。");
            }
        }

        // 读取用户列表（JSON 反序列化）
        static List<User> LoadUsers()
        {
            string json = File.ReadAllText(userFilePath);
            return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }

        // 保存用户列表（JSON 序列化，美化输出）
        static void SaveUsers(List<User> users)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(users, options);
            File.WriteAllText(userFilePath, json);
        }

        // 获取非空输入
        static string GetNonEmptyInput(string prompt)
        {
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(input))
                    Console.WriteLine("输入不能为空，请重新输入。");
            } while (string.IsNullOrEmpty(input));
            return input;
        }

        // 记录操作日志
        static void LogOperation(string operation, string username, string detail)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string logLine = $"[{timestamp}] 操作: {operation}, 用户: {username}, 详情: {detail}";
            File.AppendAllText(logFilePath, logLine + Environment.NewLine);
        }
    }

    // 用户模型
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string datetime { get; set; }
    }
}
