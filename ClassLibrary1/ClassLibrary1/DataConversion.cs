using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class DataConversion
    {
        /**
         * Sometimes you need to convert variable from one data type to another
         * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions
         */

        public void ExplicitConversion()
        {
            // EXPLICIT CONVERSION
            // CASTING
            // required when info may be lost in the conversion or it may not succeed
            // larger to smaller
            // double to int
            double myDouble = 1.54D;
            int myInt;
            myInt = (int)myDouble;
        }

        public void ImplicitConversion()
        {
            // IMPLICIT CONVERSION
            // COERCION
            // smaller to larger integral types and conversions from derived classes to base classes
            // int to float
            int myNum = 12345;
            float myFloat = myNum;
        }

        public void TypeConversion()
        {
            // TYPE CONVERSION
            // needed to convert from one type to another
            int myInt = 6;
            string myString = myInt.ToString();
        }

        public void Parsing()
        {
            // PARSING
            // similar to type conversion, but from string to number
            // valid
            string myString = "17";
            int myInt = Int32.Parse(myString);
            // invalid
            string secondString = "cat";
            int secondInt = Int32.Parse(secondString);
        }

    }
}
