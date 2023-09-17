using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int secondNumber = int.Parse(Console.ReadLine());


            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            Console.WriteLine($"Теперь первое число равно {firstNumber}, а второе равно {secondNumber}.");
        }
    }
}
