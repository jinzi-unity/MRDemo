using System;
/// <summary>
/// master主分支
/// jinquan 添加了一个注释
/// </summary>
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 1;
            int b = 2;

            int c = a + b;

            Console.WriteLine(c);
        }
        /// <summary>
        /// master实现了一个方法
        /// </summary>
        /// <param name="value"></param>
        static void LogValue(int value) {
            Console.WriteLine(value);
        }
        
    }
}
