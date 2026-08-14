namespace _8_14
{
    internal class Program
    {
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
            string user = "";
            string password = "";
            Console.WriteLine("请输入用户名:");
            user = Console.ReadLine();
            while (user == "")
            {
                Console.WriteLine("用户名为空请重新输入:");
                user = Console.ReadLine();
            }
            Console.WriteLine("请输入密码:");
            password = Console.ReadLine();
            while (password == "")
            {
                Console.WriteLine("用户名为空请重新输入:");
                password = Console.ReadLine();
            }
            string userPath = @"./user.text";
            File.AppendAllText(userPath, user + "===" + password + "\n");
        }
    }
}
