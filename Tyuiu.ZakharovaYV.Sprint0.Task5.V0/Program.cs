﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZakharovaYV.Sprint0.Task5.V0.Lib;

namespace Tyuiu.ZakharovaYV.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            // пример линейной структуры 
            Console.WriteLine("A + B =" + DataService.Addition(1, 5));
            Console.WriteLine("A - B =" + DataService.Subtraction(15, 5));
            Console.WriteLine("A * B =" + DataService.Multiplication(10, 10));
            //Пример разветвляющейся структуры находится в библиотеке классов в методе Division
            Console.WriteLine("A / B =" + DataService.Division(9, 3));
            Console.ReadKey();

        }
    }
}
