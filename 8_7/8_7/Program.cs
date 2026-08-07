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


            var result = ints
                    .GroupBy(g => (g)) // 按元素分组
                    .Select(g => g.First())               // 每组取第一个
                    .ToList();
                Console.WriteLine(String.Join(",", result));

        }
    }
}
