using _8_19.Info.User;
using _8_19.Tools;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _8_19.Manager
{
    internal class UserManager : JsonManagerBase<User>
    {
        public UserManager() : base("./UserManager.json") { }

        // ---- 新增客户（User对象重载）----
        public (string, User) Add(User user)
        {
            if (string.IsNullOrEmpty(user.Name) ||
                string.IsNullOrEmpty(user.Number) ||
                string.IsNullOrEmpty(user.RegTime) ||
                string.IsNullOrEmpty(user.Gander) ||
                string.IsNullOrEmpty(user.Phone) ||
                string.IsNullOrEmpty(user.Motto))
                throw new ArgumentException("参数错误");

            (_, List<User> list) = ReadData();
            list.Add(user);
            WriteData(list);

            return ("新增成功", user);
        }

        // ---- 新增客户（参数重载）----
        public (string, User) Add(string name, string number, string regTime, string gander, string phone, string motto)
        {
            if (string.IsNullOrEmpty(number) ||
                string.IsNullOrEmpty(regTime) ||
                string.IsNullOrEmpty(gander) ||
                string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(motto))
                throw new ArgumentException("参数错误");

            User user = new User(name, number, regTime, gander, phone, motto);
            (_, List<User> list) = ReadData();
            list.Add(user);
            WriteData(list);

            return ("新增成功", user);
        }

        // ---- 查看所有客户 ----
        public (string, List<User>) SearchAll()
        {
            (_, List<User> list) = ReadData();
            if (list.Count == 0) return ("暂无用户数据", list);
            return ("查找成功", list);
        }

        // ---- 根据ID查看单个客户 ----
        public (string, User) SearchOne(int id)
        {
            if (id <= 0) throw new ArgumentException("id必须大于0", nameof(id));

            (_, List<User> list) = ReadData();
            User? user = list.FirstOrDefault(u => u.Id == id);

            if (user == null)
                return ($"id:{id}不存在", null!);

            return ("查找成功", user);
        }
    }
}

#region    第一版
//using _8_19.Info.User;
//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Text.Json;
//using System.Threading.Tasks;

//namespace _8_19.Manager
//{
//    internal class UserManager
//    {
//        //- 添加客户（id、客户姓名、身份证号、注册时间、性别、手机号（做校验）、座右铭）
//        //- 查看所有客户信息
//        //- 根据id查看单条客户信息
//        private string _userPath = "./UserManager.json";
//        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
//        {
//            WriteIndented = true,
//            AllowTrailingCommas = true,
//            // 在JSON序列化的时候中文不变
//            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
//        };

//        internal string UserPath
//        {
//            //UserPath事先验证文件路径存在,所以后续直接调用不为空的UserPath就好
//            get
//            {
//                if (!File.Exists(_userPath)) File.Create(_userPath).Dispose();
//                return _userPath;
//            }
//            set
//            {
//                if (File.Exists(value)) _userPath = value;
//            }
//        }

//        public void WriteFile(List<User> list)
//        {
//            File.WriteAllText(UserPath, JsonSerializer.Serialize(list, JsonOpt));
//        }

//        public (string, List<User>) ReadFile()
//        {
//            //由于Path事先验证文件路径存在,所以再加上文件内容验证,所以ReadFile返回值就一定不为空串,但是要注意空列表情况
//            string str = File.ReadAllText(UserPath);
//            if (string.IsNullOrEmpty(str)) return ("文件为空", new List<User>());
//            var list = JsonSerializer.Deserialize<List<User>>(str, JsonOpt) ?? new List<User>();
//            return ("读取成功", list);
//        }

//        // 新增客户方法
//        public (string, User) Add(User user)
//        {
//            if (
//                string.IsNullOrEmpty(user.Name) ||
//                string.IsNullOrEmpty(user.Number) ||
//                string.IsNullOrEmpty(user.RegTime) ||
//                string.IsNullOrEmpty(user.Gander) ||
//                string.IsNullOrEmpty(user.Phone) ||
//                string.IsNullOrEmpty(user.Motto)
//                ) throw new ArgumentException("参数错误");            
//            //读取文件
//            (_, List<User> list) = ReadFile();
//            //添加逻辑
//            list.Add(user);
//            //写入文件
//            WriteFile(list);

//            return ("新增成功", user);
//        }
//        public (string,User) Add(string name, string number, string regTime, string gander, string phone, string motto)
//        {
//            if (string.IsNullOrEmpty(number) ||
//                string.IsNullOrEmpty(regTime) ||
//                string.IsNullOrEmpty(gander) ||
//                string.IsNullOrEmpty(phone) ||
//                string.IsNullOrEmpty(motto)
//                ) throw new ArgumentException("参数错误");
//            User user = new User(name,number,regTime,gander,phone,motto);
//            //读取文件
//            (_, List<User> list) = ReadFile();
//            //添加逻辑
//            list.Add(user);
//            //写入文件
//            WriteFile(list);

//            return ("新增成功", user);            
//        }
//        // 查看所有客户方法
//        public (string, List<User>) SearchAll()
//        {
//            //读取文件
//            (_, List<User> list) = ReadFile();
//            if (list.Count == 0) return ("暂无用户数据", list);
//            return ("查找成功", list);
//        }
//        // 查看某个客户方法
//        public (string, User) SearchOne(int id)
//        {
//            if (id <= 0) throw new ArgumentException("id必须大于0", nameof(id));
//            (_,List<User> list) = ReadFile();

//            User? user = list?.FirstOrDefault(v => v.Id == id);
//            if (!(list.Count == 0))
//            {                
//                // 这里可以根据id查找并处理对应的User对象                
//                if (user == null)
//                {
//                    return ($"id:{id}不存在", user);
//                }
//                else
//                {
//                    return ("查找成功", user);
//                }
//            }
//            else
//            {
//                return ("暂无用户数据", user);
//            }
//        }
//    }
//}
#endregion