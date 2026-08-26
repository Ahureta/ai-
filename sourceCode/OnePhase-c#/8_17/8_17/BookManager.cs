using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookManager
{
    internal class BookManager
    {
        // 属性：
        // 数据文件路径
        public string path { get; }
        // JSON序列化配置项
        public JsonSerializerOptions JsonOpts { get; }

        // 新增数据：强制要求 ==> 将list写入文件中
        public string GetPath() {            
            return File.Exists(path)?path:File.Create(path).Name;
        }
        public string AddBook(Dictionary<string, dynamic> bookDic)
        {

            // 判断图书是否已存在===>根据图书名判断(一个书名只有一本)
            if (SearchBook(bookDic["name"]) != null) throw new Exception("图书已存在,请勿重复添加!!!");
            // 新增的逻辑处理
            // 判断path路径是存在===> 不存在, 组装书籍list,序列化后 写入文件
            // 如果存在 =====> 先读取文件内容
            // 反序列化为list ====> 添加bookDic到list中
            // 序列化list ====> 写入文件
            string path = GetPath();
            List<Dictionary<string, dynamic>> bookList = new();
            
            // 读取文件===>反序列化
            var json = File.ReadAllText(path);
            // 防止反序列化为 null
            if(!string.IsNullOrEmpty(json)) { 
                bookList = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json, JsonOpts) ?? new List<Dictionary<string, dynamic>>();
            }
            bookList.Add(bookDic);
            //序列化
            string jsonStr = JsonSerializer.Serialize(bookList, JsonOpts);
            // 写入文件
            File.WriteAllText(path, jsonStr);

            return "新增数据成功!!!";
        }

        // 编辑数据
        public string EditBook(Dictionary<string, dynamic> bookDic)
        {
            // 编辑的逻辑处理
            try
            {
                string path = GetPath();
                string Text = File.ReadAllText(GetPath());
                if (string.IsNullOrEmpty(Text)) return null;
                // 修正：防止反序列化为 null
                List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(File.ReadAllText(path), JsonOpts) ?? new List<Dictionary<string, dynamic>>();
                list[list.FindIndex(item => item["name"]?.ToString() == bookDic["name"]?.ToString())] = bookDic;
                // 缺失的写回文件
                string jsonStr = JsonSerializer.Serialize(list, JsonOpts);
                File.WriteAllText(path, jsonStr);
            }
            catch (Exception ex) { 
                throw new Exception(ex.Message);
            }            
            return "ok";
        }

        // 删除数据
        public string RemoveBook(string bookName)
        {
            // 删除的逻辑处理
            try
            {
                string path = GetPath();
                string Text = File.ReadAllText(GetPath());
                if (string.IsNullOrEmpty(Text)) return null;
                // 修正：防止反序列化为 null
                List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(Text, JsonOpts) ?? new List<Dictionary<string, dynamic>>();
                int idx = list?.FindIndex(item => item["name"]?.ToString() == bookName) ?? -1;
                if (idx >= 0)
                {
                    list.RemoveAt(idx);
                    // 缺失的写回文件
                    string jsonStr = JsonSerializer.Serialize(list, JsonOpts);
                    File.WriteAllText(path, jsonStr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return bookName;
        }

        // 查询所有数据
        public List<Dictionary<string, dynamic>> SearchBook() // 返回值根据情况修改
        {
            // 查询所有数据的逻辑处理
            try
            {
                string path = GetPath();
                string Text = File.ReadAllText(GetPath());
                if (string.IsNullOrEmpty(Text)) return null;
                // 修正：防止反序列化为 null
                List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(File.ReadAllText(path), JsonOpts) ?? new List<Dictionary<string, dynamic>>();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }

        // 根据图书名称查询当前图书数据：强制要求
        public Dictionary<string, dynamic> SearchBook(string bookName) // 返回值根据情况修改
        {
            string Text = File.ReadAllText(GetPath());
            if (string.IsNullOrEmpty(Text)) return null;

            List<Dictionary<string, dynamic>> list =
                JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(Text, JsonOpts) ?? new List<Dictionary<string, dynamic>>();
            
            var dic = list?.FirstOrDefault(item =>
                item.TryGetValue("name", out var nameVal) && nameVal?.ToString() == bookName
            );
            // 查询单个图书的逻辑处理
            return dic;
        }


        //2. 完善一个借阅功能
        //    - 添加一个借阅功能的编号 比如： 5
        //    + 输入5 进入借阅功能
        //    - 将所有可借阅的书籍展示， 并要求用户输入借阅的书籍名称
        //    - 输入要借阅的书籍，实现借阅
        //3. 完善一个还书功能

        public string borrowBook(string bookName)
        {
            // 借阅的逻辑处理
 
            string path = GetPath();
            string Text = File.ReadAllText(GetPath());                
            if (string.IsNullOrEmpty(Text)) throw new Exception("json文件内容为空");
            if (string.IsNullOrEmpty(bookName)) throw new Exception("借阅的文件名不能为空");
            // 修正：防止反序列化为 null
            List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(File.ReadAllText(path), JsonOpts) ?? new List<Dictionary<string, dynamic>>();
            int idx = list.FindIndex(item => item["name"]?.ToString() == bookName.ToString());
            if (string.Equals(list[idx]["isBorrow"]?.ToString(), "true", StringComparison.OrdinalIgnoreCase))
                return "图书已被借出";            
            if (idx >= 0)
            {
                list[idx]["isBorrow"] = true; // 假设借出时 isBorrow 设为 true
                // 缺失的写回文件
                string jsonStr = JsonSerializer.Serialize(list, JsonOpts);
                File.WriteAllText(path, jsonStr);
            }

            return "借阅成功";
        }

        public string ret(string bookName)
        {
            // 归还的逻辑处理

            string path = GetPath();
            string Text = File.ReadAllText(GetPath());
            if (string.IsNullOrEmpty(Text)) throw new Exception("json文件内容为空");
            if (string.IsNullOrEmpty(bookName)) throw new Exception("归还的文件名不能为空");
            // 修正：防止反序列化为 null
            List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(File.ReadAllText(path), JsonOpts) ?? new List<Dictionary<string, dynamic>>();
            int idx = list.FindIndex(item => item["name"]?.ToString() == bookName.ToString());
            if (string.Equals(list[idx]["isBorrow"]?.ToString(), "false", StringComparison.OrdinalIgnoreCase))
                return "图书未被借出";            
            if (idx >= 0)
            {
                list[idx]["isBorrow"] = false; // 假设借出时 isBorrow 设为 true
                // 缺失的写回文件
                string jsonStr = JsonSerializer.Serialize(list, JsonOpts);
                File.WriteAllText(path, jsonStr);
            }

            return "归还成功";
        }
        // 自定义实例构造函数
        public BookManager(string bookPath, JsonSerializerOptions Opts)
        {
            // 实例化初始化属性
            path = bookPath;
            JsonOpts = Opts;
        }
    }
}
