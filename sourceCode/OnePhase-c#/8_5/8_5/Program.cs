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
            //    case 7:
            //        Console.WriteLine("周末");
            //        break;
            //    default:
            //        Console.WriteLine("输入有误");
            //        break;
            //}


            //成绩等级输出 switch 简写
            //int score = int.Parse(Console.ReadLine());
            //if (score >= 0 && score <= 100)
            //{
            //    String n2 = score switch
            //    {
            //        >= 90 => "A",
            //        >= 80 => "B",
            //        >= 70 => "C",
            //        >= 60 => "D",
            //        _ => "F"
            //    };
            //    Console.WriteLine(n2);
            //}
            //else
            //{
            //    Console.WriteLine("输入有误");                
            //}



            //三元表达式:判断 成年了/ 未成年
            //int age = int.Parse(Console.ReadLine());
            //string result = age >= 18 ? "成年了" : "未成年";
            //Console.WriteLine(result);

            //三元表达式: 判断 闰年(能被4整除但不能被100整除,能被400整除) 平年
            //int year = int.Parse(Console.ReadLine());
            //string result = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0) ? "闰年" : "平年";
            //Console.WriteLine(result);





            //账号密码验证（练习分支嵌套）：账号规定是"admin"，密码规定是"123456"。
            //让用户输入账号和密码，判断账号和密码是否正确，账号和密码都正确就输出登入成功；
            //账号不对，就输出账号不存在；密码不对，就输出密码错误。




            //选择菜单（add / edit / del）执行操作（练习多分支和switch）：
            //提示用户选择菜单（add / edit / del），判断输入的是add，就输出新增成功；
            //输入的是edit，就输出编辑成功；输入的是del，就输出删除成功。
            /*            String menu = "add / edit / del";
                        Console.WriteLine("请选择菜单：" + menu);
                        String m = Console.ReadLine();
                        switch (m)
                        {
                            case "add":
                                Console.WriteLine("新增成功");
                                break;
                            case "edit":
                                Console.WriteLine("编辑成功");
                                break;
                            case "del":
                                Console.WriteLine("删除成功");
                                break;
                            default:
                                Console.WriteLine("输入有误");
                                break;
                        }*/



            //会员打折满1000打9折，普通用户满2000打9.5折（练习多分支和分支嵌套）：
            //让用户输入自己的类型（VIP/USER）和消费金额，如果是VIP，判断消费金额是否达到1000，如果达到了，就输出他应该支付的金额，
            //如果没有达到，也输出他应该支付的金额；如果是USER，判断消费金额是否达到2000，如果达到了和没有达到，都输出他应该支付的金额。
            /*            Console.WriteLine("请输入用户类型（vip/user）：");
                        String userType = Console.ReadLine();
                        Console.WriteLine("请输入消费金额：");
                        double money = double.Parse(Console.ReadLine());
                        switch (userType)
                        {                
                            case "vip":                                        
                                if (money >= 1000)
                                {
                                    Console.WriteLine("您是VIP用户，消费金额达到1000，打9折，您应支付：" + (money * 0.9));
                                }
                                else
                                {
                                    Console.WriteLine("您是VIP用户，消费金额未达到1000，您应支付：" + money);
                                }
                                break;
                            case "user":
                                if (money >= 2000)
                                {
                                    Console.WriteLine("您是普通用户，消费金额达到2000，打9.5折，您应支付：" + (money * 0.95));
                                }
                                else
                                {
                                    Console.WriteLine("您是普通用户，消费金额未达到2000，您应支付：" + money);
                                }
                                break;

                        }*/



            //通过月份判断季节（练习switch的穿透写法）：用户输入月份，判断月份如果是3、4、5月份，就输出这是春季；如果是6、7、8月份，
            //就输出这是夏季；如果是9、10、11月份，就输出这是秋季，如果是12、1、2月份，就输出这是冬季。,
            //Console.WriteLine("请输入月份：");
            //int month = int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("这是春季");
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("这是夏季");
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("这是秋季");
            //        break;
            //    case 12:
            //    case 1:
            //    case 2:
            //        Console.WriteLine("这是冬季");
            //        break;
            //    default:
            //        Console.WriteLine("输入有误");
            //        break;
            //}



            //快递运费（练习多分支）：输入快递重量，单位是Kg，如果重量小于1Kg，输出快递费10元；
            //如果重量在1Kg~5Kg之间，就输出快递费20元；如果重量超过5Kg，就输出快递费50元。
            //double weight = double.Parse(Console.ReadLine());
            //String yuan = weight switch { 
            //    < 1 => "10元",
            //    >= 1 and <= 5 => "20元",
            //    _ => "50元"
            //};
            //Console.WriteLine("快递费：" + yuan);



            //会员等级优惠（练习多分支和switch）：输入会员等级，等级是3~5的整数，判断等级如果是5，输出终身免运费；
            //等级是4，输出每月可领优惠券；等级是3，输出购物打9折，否则没有福利。
            //int level = int.Parse(Console.ReadLine());
            //String result = level switch
            //{
            //    5 => "终身免运费",
            //    4 => "每月可领优惠券",
            //    3 => "购物打9折",
            //    _ => "没有福利"
            //};
            //Console.WriteLine(result);


            //自动售货机选商品（练习多分支和switch）：输入商品编号整数，1就输出已购买可乐；2输出已购买雪碧；3输出已购买矿泉水；否则输出无此商品。
            //int  productNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine(productNumber switch
            //{
            //    1 => "已购买可乐",
            //    2 => "已购买雪碧",
            //    3 => "已购买矿泉水",
            //    _ => "无此商品"
            //});


            //速度分级（练习多分支）：输入当前速度，如果在0~30，输出低速通过；30~60输出中速通过；60~100输出高速通过；100~120输出超速通过。
            //int speed = int.Parse(Console.ReadLine());
            //Console.WriteLine(speed switch
            //{
            //    >= 0 and <= 30 => "低速通过",
            //    > 30 and <= 60 => "中速通过",
            //    > 60 and <= 100 => "高速通过",
            //    > 100 and <= 120 => "超速通过",
            //    _ => "速度超出范围"
            //}); 
        }
    }
}
