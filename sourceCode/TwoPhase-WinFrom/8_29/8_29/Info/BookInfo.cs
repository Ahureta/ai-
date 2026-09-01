using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace _8_29.Info
{
    public class BookInfo
    {
        public int Id{ get; private set; }
        public string Uid { get; private set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string Label { get; set; }
        public bool IsBorrow { get; set; }


        // ① 无参构造函数：用于“创建”场景（表单添加），Id 自动为 0
        public BookInfo()
        {
            Uid = Guid.NewGuid().ToString();            
        }

        // ② 带Id构造函数：用于“读取”场景（从数据库加载）
        public BookInfo(int id, string uid, string uuid)
        {
            Id = id;
            Uid = uid;            
        }

        //// 无参构造函数，方便 ORM 和绑定
        //public BookInfo() { }

        //// 可选：带 Id 的构造函数，适用于从数据库读取后创建对象
        //public BookInfo(string uid,string name, string author, double price, string label, bool isBorrow)
        //{            
        //    UId = uid;
        //    Name = name;
        //    Author = author;
        //    Price = price;
        //    Label = label;
        //    IsBorrow = isBorrow;
        //}
    }
}