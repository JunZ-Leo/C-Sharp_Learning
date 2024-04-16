// See https://aka.ms/new-console-template for more information

//helloworld
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
System.Console.WriteLine("liujunzhe");

//下面是一个三角形
System.Console.WriteLine("  /|");
System.Console.WriteLine(" / |");
System.Console.WriteLine("/__|");
//常见资料结构&变数
//字串string ""v   多个字母纯文字
//字元char 'a'   表达单个字母纯文字
//整数  int 40
//浮点数  double 160.5
//布尔  bool   true   false

//变数：承载各式各样数据的容器
string name = "liujunzhe";
char sex = 'M';
int age = 21;
double height = 182.3;
bool is_male = true;

System.Console.WriteLine(name + "nice");
System.Console.WriteLine("有一个人叫" + name);
//换名字
name = "李大锤";
System.Console.WriteLine("有一个人叫" + name);
//接着换
name = "小灰";
System.Console.WriteLine("有一个人叫" + name);
//   !不能改变已定义的资料类型
//string 字串常用用法

System.Console.WriteLine("Hello");
System.Console.WriteLine("Mr.Liu");
//换行符  \n
System.Console.WriteLine("Hello \nMr.Liu");
//输出 Hello"Mr.Liu    要用到\   告诉程序\后面的程序是字符串的一部分。
System.Console.WriteLine("Hello\"Mr.Liu");
//字串相加连接
System.Console.WriteLine("Hello" + "Mr.Liu");
//查看字串长度  .Length
name = "liujunzhe";
System.Console.WriteLine(name.Length);
//方法
//转换大写
System.Console.WriteLine(name.ToUpper());
//字串常见用法

string phrase = "Hello Mr.Liu";
System.Console.WriteLine(phrase.Contains("Hello"));  //字段是否匹配
System.Console.WriteLine(phrase[0]);  //第0位字母    
//值找位置   indexOf()
System.Console.WriteLine(phrase.IndexOf('H'));  //返回0
System.Console.WriteLine(phrase.Substring(2));  //切割第二位之前的字母。 (He)llo Mr.Liu
System.Console.WriteLine(phrase.Substring(3 , 2));  //第三位后面俩



//数字用法  整数  浮点数
//加减乘除
System.Console.WriteLine(5+2);
System.Console.WriteLine(5-2);
System.Console.WriteLine(5 * 2);
System.Console.WriteLine(5 /2.0);   //整数除浮点数得浮点数
System.Console.WriteLine(5 + 2 * 3);  //11 先乘除后加减
int num = 3;
System.Console.WriteLine(num);
System.Console.WriteLine(System.Math.Abs(num-10)); //绝对值
System.Console.WriteLine(System.Math.Pow(2, 3));   //乘方
System.Console.WriteLine(System.Math.Sqrt(64));  //开根号
System.Console.WriteLine(System.Math.Max(101, 100));  //取最大值
System.Console.WriteLine(System.Math.Max(101, 100));  //取最小值
System.Console.WriteLine(System.Math.Round(3.4)); //四舍五入

//取得用户输入
System.Console.WriteLine("请输入您的名字：");   //自动会换行  write不换行
string yhxm = System.Console.ReadLine();
System.Console.WriteLine("你好"+yhxm);
//取得多个输入
System.Console.WriteLine("请输入您的性别：");
string xingbie = System.Console.ReadLine();
System.Console.WriteLine("请输入您的年纪:");
string nianling = System.Console.ReadLine();
System.Console.WriteLine("你好" + yhxm + "你是"+ xingbie +"的"+"你今年" + nianling + "岁");

//array阵列   数组

int[] scores = { 50, 60, 70, 30, 20 };
System.Console.WriteLine(scores[0]);
System.Console.WriteLine(scores[1]);
System.Console.WriteLine(scores[2]);
System.Console.WriteLine(scores[3]);
System.Console.WriteLine(scores[4]);



