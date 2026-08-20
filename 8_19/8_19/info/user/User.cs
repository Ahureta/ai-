using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_19.info.user
{
    internal class User
    {
        //- 添加客户（id、客户姓名、身份证号、注册时间、性别、手机号（做校验）、座右铭）
        //- 查看所有客户信息
        //- 根据id查看单条客户信息
        private static int _nextId = LoadNextId();   // 静态计数器

        public int Id;
        public string Name { get; set; }
        public string Number { get; }
        public string RegTime { get; }
        public string Gander { get; set; }        
        public string Phone { get; set; }
        public string Motto { get; set; }

        public User() { 
            
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
