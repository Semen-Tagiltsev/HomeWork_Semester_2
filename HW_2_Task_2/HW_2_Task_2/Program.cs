﻿using System;

namespace HW_2_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку в постфиксной записи: ");
            var element = new Calculator(new ListCalc());
            Console.WriteLine($"Резултат: {element.GetResult(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries))}") ;
        }
    }
}
