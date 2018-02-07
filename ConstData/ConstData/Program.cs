using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Const ***** \n");
            Console.WriteLine("The value of PI is: {0}", MyMathClass.PI);

            //Ошибка! нельзя изменять константу
            //MyMathClass.PI = 3.1444;

            Console.ReadLine();
        }
    }

    class MyMathClass
    {
        public static readonly double PI = 3.14;
    }

    class MyMathClass_2
    {
        public static readonly double PI;
        static MyMathClass_2()
        {
            PI = 3.14;
        }
    }


}
