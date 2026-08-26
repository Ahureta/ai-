using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _8_19.Info.User
{
    internal class User
    {
        //- 添加客户（id、客户姓名、身份证号、注册时间、性别、手机号（做校验）、座右铭）
        //- 查看所有客户信息
        //- 根据id查看单条客户信息
        private static int _nextId = LoadNextId();   // 静态计数器

        //属性的校验可以往后做便于调试
        public int Id { get; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string RegTime { get; }
        public string Gander { get; set; }
        public string Phone { get; set; }
        public string Motto { get; set; }

        public User(string name, string number, string regTime, string gander, string phone, string motto)
        {
            this.Id = GenerateId();
            this.Name = name;
            this.Number = number;
            this.RegTime = regTime;// DateTime.UtcNow.ToString();但是需要注意构造实例不一定创建用户,所以传入
            this.Gander = gander;
            this.Phone = phone;
            this.Motto = motto;
        }

        [JsonConstructor]
        public User(int id, string name, string number, string regTime, string gander, string phone, string motto)
        {
            this.Id = id;
            this.Name = name;
            this.Number = number;
            this.RegTime = regTime;// DateTime.UtcNow.ToString();但是需要注意构造实例不一定创建用户,所以传入
            this.Gander = gander;
            this.Phone = phone;
            this.Motto = motto;
        }

        protected static string IdFilePath = "./userId.txt";
        private static int GenerateId()
        {
            int id = Interlocked.Increment(ref _nextId);
            SaveNextId(_nextId);        // 持久化到文件
            return id;
        }

        private static int LoadNextId()
        {
            if (File.Exists(IdFilePath) && int.TryParse(File.ReadAllText(IdFilePath).Trim(), out int last))
                return last;
            return 0;
        }

        private static void SaveNextId(int id)
        {
            File.WriteAllText(IdFilePath, id.ToString());
        }
    }
}
