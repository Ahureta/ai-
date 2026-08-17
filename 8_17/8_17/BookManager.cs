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
            return File.Exists(path) ? throw new Exception("路径错误") : path; ; 
        }
        public string AddBook(Dictionary<string, dynamic> bookDic)
        {

            // 判断图书是否已存在===>根据图书名判断(一个书名只有一本)

            // 新增的逻辑处理
            // 判断path路径是存在===> 不存在, 组装书籍list,序列化后 写入文件
            // 如果存在 =====> 先读取文件内容
            // 反序列化为list ====> 添加bookDic到list中
            // 序列化list ====> 写入文件
            string path = GetPath();
            List<Dictionary<string, dynamic>> bookList = new();
            
            // 读取文件===>反序列化
            var json = File.ReadAllText(path);
            // 反序列化
            bookList =  JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            
            
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
                List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(File.ReadAllText(path), JsonOpts);
                list[list.FindIndex(item => item["name"] == bookDic["name"])] = bookDic;
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
                List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(File.ReadAllText(path), JsonOpts);
                list.RemoveAt(list.FindIndex(item => item["name"] == bookName));                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return "ok";
        }

        // 查询所有数据
        public List<Dictionary<string, dynamic>> SearchBook() // 返回值根据情况修改
        {
            // 查询所有数据的逻辑处理
            try
            {
                string path = GetPath();
                List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(File.ReadAllText(path), JsonOpts);
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
            string path = GetPath();
            List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(File.ReadAllText(path), JsonOpts);
            Dictionary<string,dynamic> dic= (Dictionary<string, dynamic>)list.Where(item => item["name"]== bookName);
            // 查询单个图书的逻辑处理
            return dic;
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
