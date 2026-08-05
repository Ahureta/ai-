namespace _8_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //小明择偶标准：要么资产在300w以上，要么颜值大于9.5。输入小红的资产和颜值
            //double yuan = double.Parse(Console.ReadLine());
            //Console.WriteLine(yuan);
            //double faceValue = double.Parse(Console.ReadLine());
            //Console.WriteLine(faceValue);
            //bool isSuitable = yuan > 300 || faceValue > 9.5;
            //Console.WriteLine(isSuitable);

            //小红想做车模，车模条件年龄16~22
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine(age);
            //bool isCarModel = age >= 16 && age <= 22;
            //Console.WriteLine(isCarModel);

            //根据输入的成绩判断是不及格
            //(小于60),及格(大于60小于80), 良好(大于80小于90),优秀(大于90小于100)
            //int score = int.Parse(Console.ReadLine());
            //if (score < 60)
            //{
            //    Console.WriteLine("不及格");
            //}
            //else if (score >= 60 && score < 80)
            //{
            //    Console.WriteLine("及格");
            //}
            //else if (score >= 80 && score < 90)
            //{
            //    Console.WriteLine("良好");
            //}
            //else if (score >= 90 && score <= 100)
            //{
            //    Console.WriteLine("优秀");
            //}
            //else
            //{
            //    Console.WriteLine("输入成绩有误");
            //}

            ////输入年份，判断是否是闰年(普通闰年：能被4整除但不能被100整除/世纪闰年：可以被400整除)
            //int year = int.Parse(Console.ReadLine());
            //if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            //{
            //    Console.WriteLine("是闰年");
            //}
            //else
            //{
            //    Console.WriteLine("不是闰年");
            //}

            //输出星期几
            //int n = int.Parse(Console.ReadLine());
            //switch (n)
            //{
            //    case 1:
            //        Console.WriteLine("星期一");
            //        break;
            //    case 2:
            //        Console.WriteLine("星期二");
            //        break;
            //    case 3:
            //        Console.WriteLine("星期三");
            //        break;
            //    case 4:
            //        Console.WriteLine("星期四");
            //        break;
            //    case 5:
            //        Console.WriteLine("星期五");
            //        break;
            //    case 6:
            //        Console.WriteLine("星期六");
            //        break;
            //    case 7:
            //        Console.WriteLine("星期日");
            //        break;
            //    default:
            //        Console.WriteLine("输入有误");
            //        break;
            //}


            // 输入分数 1~100
            // 判断等级输出
            // 分数90~100  输出A  ===> 分数的十位9 / 10
            // 分数80~90   输出B  ===> 分数的十位8
            // 分数70~80   输出C  ===> 分数的十位7
            // 分数60~70   输出D  ===> 分数的十位6
            // 分数1~60    输出F  ===> 分数的十位0/1/2/3/4/5

            //int score = int.Parse(Console.ReadLine());
            //int n2 = score / 10;
            //switch (n2)
            //{
            //    case 0:
            //        Console.WriteLine("F");
            //        break;
            //    case 1:
            //        Console.WriteLine("F");
            //        break;
            //    case 2:
            //        Console.WriteLine("F");
            //        break;
            //    case 3:
            //        Console.WriteLine("F");
            //        break;
            //    case 4:
            //        Console.WriteLine("F");
            //        break;
            //    case 5:
            //        Console.WriteLine("F");
            //        break;
            //    case 6:
            //        Console.WriteLine("D");
            //        break;
            //    case 7:
            //        Console.WriteLine("C");
            //        break;
            //    case 8:
            //        Console.WriteLine("B");
            //        break;
            //    case 9:
            //        Console.WriteLine("A");
            //        break;
            //    case 10:
            //        Console.WriteLine("A");
            //        break;
            //    default:
            //        Console.WriteLine("输入有误");
            //        break;
            //}
        }
    }
}
