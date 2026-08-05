namespace _8_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //计算100以内偶数的和
            //int sum = 0;
            //for (int i = 0; i<=100; i++)
            //{
            //    if(i%2==0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine("100以内偶数的和为: " + sum);

            //显示出1000-2000年中所有的闰年，并以每行四个数的形式输出
            //int count = 0;  
            //for (int i = 1000; i <= 2000; i++)
            //{
            //    if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
            //    {
            //        Console.Write(i + "\t");
            //        count++;
            //        if (count % 4 == 0)
            //        {
            //            Console.WriteLine();
            //        }
            //    }
            //}


            //输出一个倒三角形
            //for (int i = 0; i < 9; i++)
            //{
            //    for (int j = 0; j < 9 - i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            /*
            用循环计算下面的结果
            1 - 1 / 2 + 1 / 3 - 1 / 4 + ... -1 / 100
            */
            //double sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        sum += 1 / (double)i;
            //    }
            //    else
            //    {
            //        sum -= 1 / (double)i;
            //    }
            //}
            //Console.WriteLine("结果为: " + sum);


            //求20以内所有数字的阶乘的和
            //int sum = 0;
            //for(int i = 1;i<=20; i++)
            //{
            //    int factorial = 1;
            //    for (int j = 1; j <= i; j++)
            //    {
            //        factorial *= j;
            //    }
            //    sum += factorial;
            //}
            //Console.WriteLine("20以内所有数字的阶乘的和为: " + sum);


            //篮球从5米高的地方掉下来，每次弹起的高度是原来的30%，经过几次弹起，篮球的高度小于0.1米。
            //double height = 5.0;
            //for (int i = 1; height >= 0.1; i++)
            //{
            //    height *= 0.3;
            //    Console.WriteLine("第" + i + "次弹起的高度为: " + height);
            //}


            //有一个棋盘，有64个方格，在第一个方格里面放1粒芝麻重量是0.00001kg，第二个里面放2粒，第三个里面放4，棋盘上放的所有芝麻的重量是多少？
            //double totalWeight = 0.0;
            //double weight = 0.00001;
            //for (int i = 1; i <= 64; i++)
            //{
            //    //totalWeight += 0.00001 * Math.Pow(2, i);
            //    totalWeight += weight;
            //    weight = 2 * weight;
            //}
            //Console.WriteLine("棋盘上放的所有芝麻的重量为: " + totalWeight + "kg");


            //某人在银行有50000元存款。银行每月都要收取服务费，存款大于5000元时每个月收取总额的5%，总额不大于5000元的时候不收服务费；
            //假设这个人存了以后从来都不用，用循环计算银行要扣这个人的手续费能扣多少次？每次扣取后剩余多少钱？
            //double deposit = 50000.0;            
            //int i = 0;
            //for (; deposit > 5000; i++) {
            //    deposit *= 0.95;
            //}
            //Console.WriteLine("银行要扣这个人的手续费能扣 " + i + " 次，每次扣取后剩余 " + deposit + " 元");


            //猴子摘桃，猴子摘了x个桃，每天吃一半，再多吃一个，第7天吃的时候剩下一个了，猴子摘了多少桃子？
            //int peaches = 1; //第七天剩下的桃子数
            //int sum = 6;
            //for (int i = 1; i <= 6; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine("猴子摘了 " + sum + " 个桃子");

            //有个皮球，每次落地弹起都是高度的一半，如果从10米高的地方丢下，第十次弹起时，皮球总过经历了多少距离。
            //double height = 10.0;
            //double total = 10; // 初始高度
            //for (int i = 0; i < 9; i++)
            //{
            //    height /= 2;
            //    total += height * 2; // 每次弹起和落下的距离
            //}
            //Console.WriteLine("第十次弹起时，皮球总过经历了 " + total + " 米");
        }
    }
}
