using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ZakharovaYV.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        //линейная структура сложения чисел 
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        //линейная структура вычитания чисел 
        public static int Subtraction(int a, int b)
        {
            return a - b;
        }

        //линейная структура 
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        //линейная структура 
        public static double Division(int a, int b)
        {
            if (b == 0)
            {

                //демонтрация ветвления 
                // В реальных проектах нужно использовать Exception
                Console.WriteLine("Переменная b = {0} на ноль делить нельзя", b);
                return -1;
            }
            else
            {
                return a / b;
            }
        }
        
    }
}
