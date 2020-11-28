using System;

namespace ClassAndMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();

            Console.Write("num1 : ");
            var num1 = Console.ReadLine();
            decimal number1 = Decimal.Parse(num1);
            Console.Write("num2 : ");
            var num2 = Console.ReadLine();
            decimal number2 = Decimal.Parse(num2);

            Console.WriteLine(calc.Plus(number1, number2));
        }
    }
}
