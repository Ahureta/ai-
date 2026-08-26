using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _8_4
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            List<String> list = new List<String>() { "A", "B", "C", "D" };
            Console.WriteLine("第一:"+string.Join(", ", list));
            list.Add("Z");
            Console.WriteLine("第二:" + string.Join(", ", list));
            list.Insert(list.Count/2, "X");
            Console.WriteLine("第三:" + string.Join(", ", list));
            list.AddRange(new List<string>() { "Q", "W" ,"E"});
            Console.WriteLine("第四:" + string.Join(", ", list));

            var r = new Random();
            var index = r.Next(0, list.Count);
            Console.WriteLine("点名:" + list[index]);

            //Console.WriteLine(list.Insert(0, "a"));

            //void list.addRange(collect x); //向数组末尾添加集合x
            //void list.Insert(Index index, Object x); //在索引index处插入元素x
            //bool list.Remove(Object x); //删除数组中值为x的元素
            //void list.RemoveAt(Index index); //删除索引index处的元素x
            //void list.RemoveRange(Index index, int int); //删除数组索引从index开始个数为int的元素
            //void list.Clear(); //删除数组中的所有元素
            //bool list.Contains(Object x); //检查数组中是否包含元素x
            //int list.IndexOf(Object x); //查找元素x在数组中的索引
            //int list.LastIndexOf(Object x); //查找元素x在数组中最后出现处的索引
            //List<Object> list.GetRange(Index x, int int); //返回数组从索引x个数为int的多个元素
            //void list.Reverse(); //将数组翻转

            Dictionary<string, string> dictionary = new Dictionary<string, string>();// { ["A"]="1" };
            dictionary.Add("A", "1");        //添加键值对    
            //Console.WriteLine(dictionary["A"]);            
            //Console.WriteLine(dictionary.Count); // 获取键值对数量
            //bool result = dictionary.TryGetValue("A", out string value);
            //dictionary["height"] = "180"; //添加键值对，如果键已存在则更新值            
            //dictionary.Remove("gender");  //删除键值对，如果键不存在则不执行任何操作
        }
    }
}
