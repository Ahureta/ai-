using System.Collections.Generic;

namespace _8_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dictionary<string, dynamic>> goodsList = new List<Dictionary<string, dynamic>>
            {
                new Dictionary<string, dynamic>
                {
                    {"name", "机械键盘"},
                    {"price", 299.99},
                    {"code", "G001"},
                    {"stock", 120}
                },
                new Dictionary<string, dynamic>
                {
                    {"name", "无线鼠标"},
                    {"price", 89.50},
                    {"code", "G002"},
                    {"stock", 356}
                },
                new Dictionary<string, dynamic>
                {
                    {"name", "27寸显示器"},
                    {"price", 1299.00},
                    {"code", "G003"},
                    {"stock", 48}
                },
                new Dictionary<string, dynamic>
                {
                    {"name", "电竞耳机"},
                    {"price", 199.00},
                    {"code", "G004"},
                    {"stock", 85}
                },
                new Dictionary<string, dynamic>
                {
                    {"name", "电脑支架"},
                    {"price", 69.90},
                    {"code", "G005"},
                    {"stock", 210}
                }
            };

            //冒泡算法排序
            //for (int i = 0; i < goodsList.Count - 1; i++)
            //{ 
            //    for (int j = 0; j < goodsList.Count - 1- i; j++)
            //    {
            //        var goods = goodsList[j];
            //        var nextGoods = goodsList[j+1];
            //        double price = goods["price"];                    
            //        double nextPrice = nextGoods["price"];
            //        if (price > nextPrice)
            //        {
            //            goodsList[j] = nextGoods;
            //            goodsList[j+1] = goods;
            //        }
            //    }
            //}


            //选择排序算法
            //for (int i = 0; i < goodsList.Count - 1; i++)
            //{
            //    var goods = goodsList[i];
            //    double price = goods["price"];
            //    for (int j = i+1; j < goodsList.Count; j++)
            //    {
            //        var nextGoods = goodsList[j];
            //        double nextPrice = nextGoods["price"];
            //        if (price > nextPrice)
            //        {
            //            goodsList[i] = nextGoods;
            //            goodsList[j] = goods;
            //            goods = nextGoods;
            //            price = nextPrice;
            //        }
            //    }
            //}            
            ////小到大:电脑支架,无线鼠标,电竞耳机,机械键盘,27寸显示器            
            //Console.WriteLine("按价格从低到高排序后的商品列表："+ string.Join(",", goodsList.Select(g => g["name"])));

            //foreach 所遍历的是引用的副本,所以不可修改原始集合,只能修改副本所指向的对象的属性。当然前提是对象是可修改的.


            List<int> ints = new List<int> { 1, 3, 3, 4, 5, 6, 7, 7, 8, 6, 4, 2, 3 };

            //class GoodsComparer : IEqualityComparer<Goods>
            //{
            //    public bool Equals(Goods x, Goods y)
            //    {
            //        if (x == null || y == null) return false;
            //        return x.Name == y.Name && x.Price == y.Price;
            //    }

            //    public int GetHashCode(Goods obj)
            //    {
            //        // 必须重写 GetHashCode，否则 HashSet 找不到元素
            //        return HashCode.Combine(obj.Name, obj.Price);
            //    }
            //}
            //var result = list.Distinct(new GoodsComparer()).ToList();


            //var result = ints
            //         .GroupBy(g => (g)) // 按元素分组
            //         .Select(g => g.First())               // 每组取第一个
            //         .ToList();
            //Console.WriteLine(String.Join(",", result));



            //Console.WriteLine("输入price或者stock以及ASC(1)或者DSC(0)排序");    //LINQ.OrderByDescending()
            //String s = Console.ReadLine();
            //String orderInput = Console.ReadLine();
            //bool isAsc;
            //if (orderInput == "1" || orderInput.Equals("asc", StringComparison.OrdinalIgnoreCase))
            //{
            //    isAsc = true;
            //}
            //else if (orderInput == "0" || orderInput.Equals("dsc", StringComparison.OrdinalIgnoreCase))
            //{
            //    isAsc = false;
            //}
            //else if (!bool.TryParse(orderInput, out isAsc)) // 兼容true/false输入
            //{
            //    Console.WriteLine("排序方式输入错误！请输入1/0/ASC/DSC");
            //    return;
            //}
            //var result = isAsc
            //    ? goodsList.OrderBy(g => g[s]).ToList()
            //    : goodsList.OrderByDescending(g => g[s]).ToList();

            //foreach (var goods in result)
            //{
            //    Console.WriteLine($"商品名称: {goods["name"]}, 价格: {goods["price"]}, 库存: {goods["stock"]}");
            //}



            List<Dictionary<string, dynamic>> singerList = new List<Dictionary<string, dynamic>>
            {
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1001},
                    {"singerName", "周杰伦"},
                    {"genre", "流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1002},
                    {"singerName", "林俊杰"},
                    {"genre", "华语流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1003},
                    {"singerName", "邓紫棋"},
                    {"genre", "流行、摇滚"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1004},
                    {"singerName", "薛之谦"},
                    {"genre", "抒情流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1005},
                    {"singerName", "毛不易"},
                    {"genre", "民谣流行"}
                }
            };

            List<Dictionary<string, dynamic>> songList = new List<Dictionary<string, dynamic>>
            {
                new Dictionary<string, dynamic>
                {
                    {"songId", 10001},
                    {"singerId", 1001},
                    {"songName", "青花瓷"},
                    {"duration", 239}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 10002},
                    {"singerId", 1001},
                    {"songName", "发如雪"},
                    {"duration", 253}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 10003},
                    {"singerId", 1001},
                    {"songName", "东风破"},
                    {"duration", 215}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 1004},
                    {"singerId", 3002},
                    {"songName", "不为谁而作的歌"},
                    {"duration", 296}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 1005},
                    {"singerId", 1002},
                    {"songName", "背对背拥抱"},
                    {"duration", 262}
                }
            };


            //singerList专辑
            //songList歌曲
            //2、通过歌曲查找歌手
            //Console.WriteLine("输入歌曲名称：");
            //string song = Console.ReadLine();

            //foreach (var songItem in songList)
            //{
            //    if (songItem["songName"].ToString().Equals(song, StringComparison.OrdinalIgnoreCase))
            //    {
            //        int singerId = songItem["singerId"];
            //        var singer = singerList.Find(s => s["singerId"] == singerId);
            //        if (singer != null)
            //        {
            //            Console.WriteLine($"歌曲《{song}》的歌手是：{singer["singerName"]}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"未找到歌曲《{song}》对应的歌手信息。");
            //        }
            //        return;
            //    }
            //}

            //2、通过歌曲查找歌手 整活, 别用
            ////songList.Find(s => s["songName"].ToString().Equals(Console.ReadLine(), StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine("输入歌曲名称：");
            //string song = Console.ReadLine();
            //var singer = singerList
            //            .Find(s => s["singerId"] == songList.Find(s => s["songName"]
            //                .ToString()
            //                .Equals(song, StringComparison.OrdinalIgnoreCase))["singerId"]
            //            );
            //Console.WriteLine(singer["singerName"]);
        }
    }
}
