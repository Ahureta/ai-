namespace _8_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region    思考
            //int[] a = { 1, 2, 3, 4, 5, 6, 7 };
            //int[] b = new int[a.Length];
            //Array.Copy(a, b, a.Length);
            //b[0] = 9;
            //Console.WriteLine(b[0]);
            //Console.WriteLine(a[0]);

            //var s = (List<int> a) => {
            //    Console.WriteLine(a[0]);
            //    a = new List<int>() {6,2,1 };   //如果加了ref就会强关联结果会不一样.         
            //};
            //List<int> l = new List<int>() {1,2,3 };
            //s(l);
            //Console.WriteLine(l[0]);

            //ref和out不同的是,ref从外部传入引用并绑定,out是从内部传出并绑定.

            //Func<int,int> s = n => n = 10;
            //1.只有一个参数时，可以省略小括号
            //2.方法体只有一行时，可以省略大括号和 return
            //3.如果函数体有多行，大括号和 return不能省略


            // 错误原因：C# 7.0 及以上版本支持元组语法，但单元素元组必须显式指定类型，否则会被当作带括号的表达式。
            // 修正方法：为单元素元组指定类型，或添加第二个元素。
            //var a = (1, 0); // 示例：二元组
            // 或者
            // var a = ValueTuple.Create(1); // 单元素元组   

            //var (b, _) = a;
            //Console.WriteLine(b);


            //==是比较引用,如果是引用类型就比较引用,如果是值类型就比较值.quals比较引用类型的值.(重写后的quals)

            #endregion

            #region    作业
            List<Dictionary<string, dynamic>> list = new() {
                new Dictionary<string, dynamic>(){
                    ["name"] = "zs",
                    ["age"] = 29,
                    ["isMan"] = true,
                    ["isSingle"] = true,
                    ["salary"] = 4200
                },
                new Dictionary<string, dynamic>(){
                    ["name"] = "ls",
                    ["age"] = 20,
                    ["isMan"] = false,
                    ["isSingle"] = true,
                    ["salary"] = 3400
                },
                new Dictionary<string, dynamic>(){
                    ["name"] = "ww",
                    ["age"] = 19,
                    ["isMan"] = true,
                    ["isSingle"] = false,
                    ["salary"] = 6000
                },
                new Dictionary<string, dynamic>(){
                    ["name"] = "zl",
                    ["age"] = 14,
                    ["isMan"] = false,
                    ["isSingle"] = true,
                    ["salary"] = 2000
                },
                new Dictionary<string, dynamic>(){
                    ["name"] = "sq",
                    ["age"] = 35,
                    ["isMan"] = true,
                    ["isSingle"] = false,
                    ["salary"] = 7000
                },
                new Dictionary<string, dynamic>(){
                    ["name"] = "zb",
                    ["age"] = 27,
                    ["isMan"] = false,
                    ["isSingle"] = true,
                    ["salary"] = 2900
                },
            };

            // 作业1
            // Find: 要求查找年龄小于20的
            foreach (Dictionary<string,dynamic>item in list.FindAll(item => item["age"] < 20)) Console.WriteLine(string.Join(",",item));
            // FindLast: 要求查找年龄大于25的
            foreach (Dictionary<string, dynamic> item in list.FindAll(item => item["age"] > 25)) Console.WriteLine(string.Join(",", item));
            // FindAll: 找出性别男的
            foreach (Dictionary<string, dynamic> item in list.FindAll(item => item["isMan"] == true)) Console.WriteLine(string.Join(",", item));
            // FindIndex: 找出薪水大于5000
            foreach (Dictionary<string, dynamic> item in list.FindAll(item => item["salary"] > 5000)) Console.WriteLine(string.Join(",", item));
            // FindLastIndex: 找出薪水小于3000
            foreach (Dictionary<string, dynamic> item in list.FindAll(item => item["salary"] < 3000)) Console.WriteLine(string.Join(",", item));
            // Exists: 判断是否有薪水大于5000
            Console.WriteLine(list.Exists(item => item["salary"] > 5000));
            // ForEach: 输出每个的 名字-年龄-薪水
            list.ForEach(item => {
                Console.WriteLine($"{item["name"]}+{item["age"]}+{item["salary"]}");                
                });
            // ConvertAll: 映射得到一个所以薪水的list
            foreach(int item in list.ConvertAll(item => item["salary"])) Console.WriteLine(item);
            //TrueForAll: 判断是否都成年
            Console.WriteLine(list.TrueForAll(item => item["age"] > 18));
            // IndexOf
            //需要一个判断器comparer,否则将比较引用.
            int a = list.IndexOf(new Dictionary<string, dynamic>()
            {
                ["name"] = "zb",
                ["age"] = 27,
                ["isMan"] = false,
                ["isSingle"] = true,
                ["salary"] = 2900
            });
            Console.WriteLine(a);
            // LastIndexOf
            //同上

            //作业2: 封装一个函数 接收一个字符串; 返回一个字典,键是字符串的每个字符,键值是这个字符在字符串中出现的次数
            //神秘小代码
            Dictionary<string, int> func(string str) =>
                str.GroupBy(c => c.ToString())
                   .ToDictionary(g => g.Key, g => g.Count());
            Console.WriteLine(string.Join(",", func("1231")));            
            //Dictionary<string, int> func(string str)
            //{
            //    Dictionary<string, int> d = new Dictionary<string, int>();
            //    foreach (char c in str)
            //    {
            //        string key = c.ToString();
            //        if (d.ContainsKey(key))
            //            d[key]++;
            //        else
            //            d[key] = 1;
            //    }
            //    return d;
            //}
            //Dictionary<string,int> func(string str) {
            //    Dictionary<string, int> d = new Dictionary<string, int>();
            //    List<char> list = str.ToList();
            //    list.ForEach(item => d[item.ToString()]+=1);    //可惜需要判断,那不如直接trygetvalue
            //    return d;
            //}

            #endregion
        }
    }
}
