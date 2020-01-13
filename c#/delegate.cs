/*
委托自己的理解是特殊得类，用户自定义类型
委托是方法的抽象，存储的是具有相同参数类型和返回值类型的方法的地址，调用的时候将会执行这个方法

*/

//声明
public delegate void Test();
public delegate int Test(int m);
public delegate void Tddd(string s);

//委托的实例化

//委托类名 委托实例名 = new 委托类名(Target) ;
MyDel2 testDel=new MyDel2(Add);
MyDel2 testDel1 = Add;//可以简写，会自动推断类型

//完整实例
namespace delegateTest
{
    public delegate int MyCalculator(int num1, int num2);
    class Program
    {
        static void Main(string[] args)
        {
            MyCalculator myCal=new MyCalculator(Add);
            int addNum= myCal(1,2);

            MyCalculator myCal1 = Sub;
            int subNum = myCal1.Invoke(1, 2);

            Console.WriteLine("addNum:{0},subNum:{1}", addNum, subNum);
            
            int calNum = Calculate(1, 2, Add);
            Console.WriteLine("calNum:{0}", calNum);
        }

        static int Add(int num1, int num2)
        {
            Console.WriteLine("num1 + num2={0}",num1 + num2);
            return num1 + num2;
        }
        static int Sub(int num1, int num2)
        {
            Console.WriteLine("num1 - num2={0}", num1 - num2);
            return num1 - num2;
        }
        static int Calculate(int num1,int num2,MyCalculator calDel)
        {
            return calDel(num1,num2);
        }
    }
}

//泛型委托
//主要封装了三个委托类型 三种泛型委托包括：Func委托、Action委托和Predicate委托。

func 有返回参数
action 没有返回参数
predicate 返回bool
namespace delegateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int calNum = Calculate(1, 2, Sub);
            Console.WriteLine("calNum:{0}", calNum);// -1
        }
        static int Calculate(int num1, int num2, Func<int, int, int> calDel)
        {
            return calDel(num1,num2);
        }
        static int Sub(int num1, int num2)
        {
            Console.WriteLine("num1 - num2={0}", num1 - num2);
            return num1 - num2;
        }
    }
}

namespace delegateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DoSome("hello",Say);// hello
        }
        static void DoSome(string str,Action<string> doAction)
        {
            doAction(str);
        }
        static void Say(string str)
        {
            Console.WriteLine(str);
        }
    }
}

//匿名委托 这个基本被lambda表达式所取代

//lambda表达式
MyCalculator myCal = (num1, num2) =>  num1 + num2;
int num = myCal(1, 2);// 3

MyCalculator myCal = (int num1, int num2)=>
{
    Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
    return num1 + num2;
};
int num = myCal(1, 2);// 3

语句Lambda不可以省略{}和return语句。

//https://www.cnblogs.com/willingtolove/p/11279562.html  重要参考