using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApplication6
{
    class Program
    {
        //复合类型：结构体
        struct ComplexNumber
        {
            public double a;
            public double b;

            public void Write()
            {
                Console.WriteLine("{0}+{1}i", a, b);
            }
        }

        //复合类型：枚举
        enum MyDate //使用enum创建枚举
        {
            Sun=0,
            Mon=1,
            Tue=2,
            Wed=3,
            Thi=4,
            Fri=5,
            Sat=6
        }
        enum Weekday
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }

        //引用类型：类
        class ComplexNumber  
        {
            public double a;
            public double b;

            public void Write()
            {
                Console.WriteLine("{0}+{1}i", a, b);
            }
        }

        //引用类型：类
        class car
        {
            private int _百公里耗油 = 10;
            private int _油箱容积 = 60;
            private int _油表;
            private int _公里数;
            public int 百公里耗油
            {
                get { return 百公里耗油; }
            }
            public int 油箱容积
            {
                get { return _油箱容积; }
            }
            public int 油表
            {
                get { return _油表; }
                set { _油表 = value; }
            }
            public int 公里数
            {
                get { return _公里数; }
                set { _公里数 = value; }
            }
            public car()
            {
                _油表 = _油箱容积;
                _公里数 = 0;
            }
            public car(int 当前油表)
            {
                _油表 = 当前油表;
                _公里数 = 0;
            }
            public car(int 当前油表, int 当前里程)
            {
                _油表 = 当前油表;
                _公里数 = 当前里程;
            }
            private int 计算耗油(int 行驶公里数)
            {
                return 行驶公里数 * _百公里耗油 / 100;
            }
            public void 行驶(int 行驶公里数)
            {
                Console.WriteLine("行驶{0}公里开始", 行驶公里数);
                if (_油表 > 计算耗油(行驶公里数))
                {
                    _公里数 += 行驶公里数;
                    _油表 -= 计算耗油(行驶公里数);
                    Console.WriteLine("行驶完毕");
                }
                else
                    Console.WriteLine("油耗不足，行驶失败");
            }
            public void 加油()
            {
                Console.WriteLine("开始加油");
                int 需要加的油 = _油箱容积 - _油表;
                _油表 += 需要加的油;
                Console.WriteLine("加油完毕，一共加了{0}升", 需要加的油);
            }
            public void 加油(int 加油体积)
            {
                Console.WriteLine("加油{0}升开始", 加油体积);
                if (加油体积 < _油箱容积)
                {
                    _油表 += 加油体积;
                    Console.WriteLine("加油完毕");
                }
                else
                    Console.WriteLine("超过最大油箱容积，加油失败");
            }
            public void 获取当前汽车信息()
            {
                Console.WriteLine(string.Format("当前油表：{0}当前里数{1}", _油表, _公里数));
            }
        }


        //is操作符
        static void Test(object o)
        {
            ClassA a;//声明类A的对象a
            ClassB b;//声明类B的对象b

            if (o is ClassA)//如果o是类A
            {
                Console.WriteLine("o 是类A");
                a = (ClassA)o;//可以把o转化为类A，而不出现异常
            }
            else if (o is ClassB)//如果o是类B
            {
                Console.WriteLine("o is 类B");
                b = (ClassB)o;//可以把o转化为类B，而不出现异常
            }
            else
            {
                Console.WriteLine("o 不是类A，也不是类B.");
                Console.WriteLine("o是{0}", o.GetType());//输出o的类型
            }
        }

        //泛型
        public class Stack<T> 
        {
            private T[] m_item;//定义一个T型的数组
            public T Pop() {...}//出栈
            public void Push(T item){...}//入栈
            public Stack(int i) //堆栈类的构造函数
            {
                this.m_item = new T[i]; //初始化数组}
            }

        static void Main(string[] args)
        {
            //简单类型：整形、实数类型、布尔型、字符型
            int color = 4;
            double x = 1.2;
            bool isDrawsuccessful = true;
            char a = 's';
            char b = '圆';
            char c = '\\';
            string s = “人”;
            double r = 0,s = 0;          //定义变量半径r,面积变量s
            const double pi = 3.14;      //定义常量圆周率pi
            Console.WriteLine("请输入圆的半径:\n");
            double.TryParse(Console.ReadLine(), out r);//读取用户输入的半径
            s = pi * r * r;
            Console.WriteLine("圆的半径是：{0}",r);
            Console.WriteLine("圆的面积是：{0}",s);
            Console.ReadLine();

            //引用类型：数组
            //一维数组
            ComplexNumber c1 = new ComplexNumber();
            c1.a = 1.5;
            c1.b = 3;
            //多维数组
            int[,] x = new int[2, 3] { { 1, 2, 3 }, { 3, 5, 8 } };
            int[,] y = new int[,] { { 10, 50 }, { 25, 75 }, { 50, 150 }, { 100, 80 } };
            int[, ,] z = { { { 1, 2 }, { 3, 5 }, { 8, 13 } }, { { 1, 2 }, { 3, 5 }, { 8, 13 } } };

            //类型转换：显示转换
            Weekday w1 = 0;
            Weekday w2 = (Weekday)3; // 显式转换
            Weekday w3 = (Weekday)100; // 显式转换
            //类型转换：隐式转换
            int a = 100;
            long b = a;

            //类型转换：引用类型之间的转换
            Graduate g1 = new Graduate();
            g1.name = "陈亮";
            Student s1 = g1; // 隐式转换
            Student s2 = new Student();
            s2.name = "宋燕燕";
            Graduate g2 = (Graduate)s1; // 显式转换

            //汽车类的实例化
            car car = new car();
            car.行驶(100);
            car.获取当前汽车信息();
            car.行驶(400);
            car.获取当前汽车信息();
            car.加油();
            car.获取当前汽车信息();
            car.加油();
            car.获取当前汽车信息();
        }
    }
}