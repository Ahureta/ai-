using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8_17
{
    //List<Dictionary<string, dynamic>> data = new List<Dictionary<string, dynamic>>(){
    //    new Dictionary<string, dynamic>(){
    //        ["name"] = "三国演义",
    //        ["author"] = "罗贯中",
    //        ["isBorrow"] = true/false, // false表示还在书库中，true表示外借
    //        ["id"] = 0~1之间的随机小数,
    //        ["mark"] = "言情、武侠",
    //        ["price"] = 56.09 // 价格
    //    },
    //};
    internal class book
    {
        private string _name;          // 私有字段
        private string _author;
        private bool _isBorrow;
        private int _id;
        private string _mark;
        private double _price;

        public string Name
        {
            get => _name;
            set
            {
                // 验证逻辑
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("名称不能为空");
                // 如果需要更严格的验证，可以用正则
                // if (!Regex.IsMatch(value, @"^[\u4e00-\u9fa5a-zA-Z0-9]+$"))
                //     throw new ArgumentException("名称只能包含中文、字母、数字");
                _name = value;
            }
        }

        // 其他属性类似...
        public string Author
        {
            get => _author;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("作者不能为空");
                _author = value;
            }
        }

        public bool IsBorrow
        {
            get => _isBorrow;
            set => _isBorrow = value;            
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Mark
        {
            get => _mark;
            set => _mark = value;
        }

        public double Price
        {
            get => Math.Round(_price, 2);  // 返回保留两位小数的值
            set
            {
                if (value < 0)
                    throw new ArgumentException("价格不能为负数");
                _price = value;
            }
        }       
    }
}
