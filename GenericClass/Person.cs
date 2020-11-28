using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClass
{
    internal class Person
    {
        public int No { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("No.{0} {1} ({3})\t{2}", No, Name, Phone, Age);
        }
    }
}
