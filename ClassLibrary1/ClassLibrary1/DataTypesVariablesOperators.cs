using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class DataTypesVariablesOperators
    {
        /**
         * Variables are writtens as:
         * DATATYPE variableName = value;
         * 
         * terminate lines with the semicolon
         */

        void DataTypeMethods()
        {
            void UnsignedIntegerDataTypes()
            {
                // UNSIGNED INTEGER DATA TYPES --> NO NEGATIVES
                // 8 bit unsigned integer, range 0 --> 255
                byte myByte = 255;
                // 16 bit unsigned integer, range 0 to 65,535
                ushort myUShort = 65535;
                // 32 bit unsigned integer, range 0 --> 4294967295
                uint myUInt = 4294967295;
                // 64 bit unsigned integer, range 0 --> 18,446,744,073,709,551,615
                ulong myULong = 18446744073709551615;
            }

            void SignedIntegerDataTypes()
            {
                // SIGNED INTEGER DATA TYPES --> CAN BE NEGATIVE
                // 8 bit signed integer, range -128 --> 127
                sbyte mySByte = -128;
                // 16 bit signed integer, range -32,768 to 32,767
                short myShort = -32768;
                // 32 bit signed integer, range -2,147,483,648 --> 2,147,483,647
                int myInt = -2147483648;
                // 64 bit unsigned integer, range -9,223,372,036,854,775,808 --> 9,223,372,036,854,775,807
                long myLong = -9223372036854775808L; // write as 0L
            }

            void FloatPointType()
            {
                // FLOAT POINT TYPE
                // 32-bit single-precision floating point type, range -3.4 x 10^38 --> + 3.4 x 10^38
                float myFloat = 5.3F; // write as 0.0F
                                      // 64-bit double-precision floating point type, range (+/-)5.0 x 10^-324 to (+/-)1.7 x 10^308
                double myDouble = 5.3D; // write as 0.0D
            }

            void FixedPointType()
            {
                // FIXED POINT TYPE (FIXED PRECISION NUMBER)
                // 128-bit precise decimal values with 28-29 significant digits, range (-7.9 x 1028 to 7.9 x 1028) / 100 to 28
                decimal myDecimal = 5.3M; // write as 0.0M
            }

            void Boolean()
            {
                // BOOLEAN
                // either true or false
                bool myTrueBool = true;
                bool myFalseBool = false;
            }

            void String()
            {
                // STRING
                // Derived from System.string
                string myString = "This is a string";
            }

            void Character()
            {
                // CHARACTER
                // 16 bit Unicode character, range U +0000 --> U +ffff
                // See: https://www.rapidtables.com/code/text/unicode-characters.html
                char mySingleChar = 'C';
                char myChar = "Cat"[0]; // will print "C" as it is the first index
            }

            void Constants()
            {
                // constants
                // const values cannot be changed
                const double pi = 3.1459;
            }
        }

        /**
         * OPERATORS
         * 
         * 
         * */


        bool OperatorMethods()
        {
            // ASSIGNMENT OPERATORS
            int num1 = 5; // equals, assigns values
            int num2 = 5;
            num2 += num1; // num2 = num2 + num1
            num2 -= num1; // num2 = num2 - num1
            num2 *= num1; // num2 = num2 * num1
            num2 /= num1; // num2 = num2 / num1
            num2 %= 2; // num2 = num2 % 2. modulo, remainder. returns the remainder, this example would be num2 = 5 % 2, or 5 / 2 = remainder 1.

            // COMPARISON OPERATORS
            // < = less than
            bool complete = num2 < num1; // returns true or false
            // > = greater than
            complete = num2 > num1; // returns true or false
            // <= less than or equal to
            complete = num2 >= num1; // returns true or false
            // >= greater than or equal to
            complete = num2 <= num1; // returns true or false
            // !=, not equal to
            complete = num2 != num1; // returns true or false 
            // ==, is equal to
            complete = num2 == num1; // returns true or false
            // compare strings with .Equals
            string test = "test";
            complete = test.Equals("test");

            // ARITHMETIC OPERATORS
            // +, -, *, /
            // %, modulo, remainder of
            int myInt = 5 % 2; // is the same as 5 / 2 = 2 with a remainder of 1. The percent sign states that you want to know the remainder
            // ++,  increment one
            myInt++; // myInt + 1
            Console.WriteLine("Int is {0}.", myInt); // {0} refers to the first index
            Console.WriteLine("Int is {0}.", myInt++); // after write line, add one
            Console.WriteLine("Int is {0}.", ++myInt); // prior to write line, add one
            // --, decrease value by one
            myInt--;

            // LOGICAL OPERATORS
            bool a = true;
            bool b = true;
            // &&, logical and
            complete = a && b; // if boolOne and boolTwo are true
            // ||, logical or
            complete = a || b; // if a or b are true 
            // !, not
            complete = a && !b; // if a is true and b is not true


        }





    }
}
