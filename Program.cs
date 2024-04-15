// See https://aka.ms/new-console-template for more information

//

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
System.Console.WriteLine("Hello"+"Mr.Liu");
//查看字串长度  .Length
name = "liujunzhe";
System.Console.WriteLine(name.Length);
//方法
//转换大写
System.Console.WriteLine(name.ToUpper());






