using System;

namespace GettingUsedToTheConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            byte byteNumber = 127;
            short shortNumber = 32767;
            int integerNumber = 2147483647;
            long longNumber = 9223372036854775807;
            Int16 _16bitNumber = 32767; // short    (.net)
            Int32 _32bitNumber = 2147483647; // int      (.net)
            Int64 _64bitNumber = 9223372036854775807; // long     (.net)

            float floatNumebr;      // 4byte
            double doubleNumber;    // 8byte
            decimal decimalNumber;  // 16byte

            char character; // 16bit Unicode
            string characterString; // unicode

            var variable = 15; // Type inference
            dynamic dynamicLanguageRuntime; // like Ruby, Python

            Console.WriteLine(variable + " is variable Type");

            Console.Write("input value : ");

            var input = Console.ReadLine();
            if (input == variable.ToString())
            {
                Console.WriteLine("same value");
            }
            else
            {
                Console.WriteLine("different value");
                var num = 1;

                while (true)
                {
                    Console.Write("{0,3}", num++);
                    if (variable == num)
                    {
                        Console.WriteLine();
                        Console.WriteLine("variable is {0}", num);
                        break;
                    }
                }
            }
        }
    }
}
