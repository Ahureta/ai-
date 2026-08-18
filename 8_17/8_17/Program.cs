using System.Text.Json;

namespace BookManager
{
    internal class Program
    {

        static void Main(string[] args)
        {            
            // 实例化图书对象
            BookManager BM = new BookManager("./book.json", new JsonSerializerOptions
            {
                WriteIndented = true, // 美化格式内容
                AllowTrailingCommas = true,
            });


            string num = "";
            while (num != "0")
            {
                // 提示信息
                Console.WriteLine("======欢迎来到图书管理系统======");
                Console.WriteLine("1: 新增图书");
                Console.WriteLine("2: 删除图书");
                Console.WriteLine("3: 编辑图书");
                Console.WriteLine("4: 查询所有图书");
                Console.WriteLine("5: 查询单个图书");
                Console.WriteLine("0: 退出");
                num = Console.ReadLine();

                switch (num)
                {
                    case "1":
                        Console.WriteLine("----新增图书----");
                        Console.WriteLine("请输入书名");
                        string bookName = Console.ReadLine();
                        Console.WriteLine("请输入作者");
                        string author = Console.ReadLine();
                        Console.WriteLine("请输入标签");
                        string mark = Console.ReadLine();
                        Console.WriteLine("请输入价格");
                        double price = double.Parse(Console.ReadLine());
                        // 组装 书籍 字典
                        Dictionary<string, dynamic> bookDic = new()
                        {
                            ["name"] = bookName,
                            ["author"] = author,
                            ["isBorrow"] = false,
                            ["id"] = new Random().NextDouble(),
                            ["mark"] = mark,
                            ["price"] = price
                        };
                        //Dictionary<string, dynamic> bookDic = new()
                        //{
                        //    ["name"] = "qwe",
                        //    ["author"] = "erwe",
                        //    ["isBorrow"] = false,
                        //    ["id"] = new Random().NextDouble(),
                        //    ["mark"] = "sdf",
                        //    ["price"] = 1234
                        //};
                        // 调用实例方法  实现 添加书籍
                        string res = BM.AddBook(bookDic);
                        Console.WriteLine(res);
                        break;
                    case "2":
                        Console.WriteLine("----删除图书----");
                        Console.WriteLine("请输入要删除的书名");
                        string delBookName = Console.ReadLine();                        
                        Console.WriteLine("删除"+BM.RemoveBook(delBookName)+"成功");
                        break;

                    case "3":
                        Console.WriteLine("----编辑图书----");
                        Console.WriteLine("请输入要编辑的书名");
                        string editBookName = Console.ReadLine();
                        var bookToEdit = BM.SearchBook(editBookName);
                        if (bookToEdit != null)
                        {
                            Console.WriteLine("请输入新的作者");
                            string newAuthor = Console.ReadLine();
                            Console.WriteLine("请输入新的标签");
                            string newMark = Console.ReadLine();
                            Console.WriteLine("请输入新的价格");
                            double newPrice = double.Parse(Console.ReadLine());
                            bookToEdit["author"] = newAuthor;
                            bookToEdit["mark"] = newMark;
                            bookToEdit["price"] = newPrice;
                            Console.WriteLine(BM.EditBook(bookToEdit));
                        }
                        else
                        {
                            Console.WriteLine("未找到该图书");
                        }
                        break;

                    case "4":
                        Console.WriteLine("----查询所有图书----");
                        var books = BM.SearchBook();
                        if (books != null && books.Count > 0)
                        {
                            foreach (var b in books)
                            {
                                Console.WriteLine($"书名: {b["name"]}, 作者: {b["author"]}, 标签: {b["mark"]}, 价格: {b["price"]}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("未找到图书");
                        }
                        break;
                    case "5":
                        Console.WriteLine("----查询单个图书----");
                        Console.WriteLine("请输入要查询的书名");
                        string searchBookName = Console.ReadLine();
                        var book = BM.SearchBook(searchBookName);
                        if (book != null)
                        {
                            Console.WriteLine($"书名: {book["name"]}, 作者: {book["author"]}, 标签: {book["mark"]}, 价格: {book["price"]}");
                        }
                        else
                        {
                            Console.WriteLine("未找到该图书");
                        }
                        break;
                    case "0":
                        Console.WriteLine("--**退出**--");
                        break;
                    default:
                        Console.WriteLine("****输入有误****");
                        break;
                }


            }
        }
    }
}
