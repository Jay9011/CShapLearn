using System;

namespace GettingUsedToTheConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            byte byteNumber;
            short shortNumber;
            int integerNumber;
            long longNumber;
            Int16 _16bitNumber; // short    (.net)
            Int32 _32bitNumber; // int      (.net)
            Int64 _64bitNumber; // long     (.net)

            float floatNumebr;      // 4byte
            double doubleNumber;    // 8byte
            decimal decimalNumber;  // 16byte

            char character; // 16bit Unicode
            string characterString; // unicode

            var variable = 15; // Type inference
            dynamic dynamicLanguageRuntime; // like Ruby, Python

            Console.WriteLine(variable + " is variable Type");
        }
    }
}
