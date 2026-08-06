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


            for (int i = 0; i < goodsList.Count - 1; i++)
            {
                var goods = goodsList[i];
                double price = goods["price"];
                for (int j = i+1; j < goodsList.Count; j++)
                {
                    var nextGoods = goodsList[j];
                    double nextPrice = nextGoods["price"];
                    if (price > nextPrice)
                    {
                        goodsList[i] = nextGoods;
                        goodsList[j] = goods;
                        goods = nextGoods;
                        price = nextPrice;
                    }
                }
            }            
            //小到大:电脑支架,无线鼠标,电竞耳机,机械键盘,27寸显示器            
            Console.WriteLine("按价格从低到高排序后的商品列表："+ string.Join(",", goodsList.Select(g => g["name"])));
        }
    }
}
