using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndMethod
{
    class Calc
    {
        public decimal? Plus<T>(T num1, T num2)
        {
            return (num1 as decimal?) + (num2 as decimal?);
        }
    }
}
