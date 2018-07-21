using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class IfElseSwitch
    {
        /**
         * IF / ELSE STATEMENTS
         * if (condition) 
         * {
         *      statements if the conditions are met;
         * } else
         * {
         *      statements if the conditions are not met;
         * }
         * 
         * can continue infinitely with if / else if / else if / else
         * **/

        void IfStatement()
        {
            bool result = true;
            if (result) // if result is true
            {
                // do something
            }

            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            int number, numberTwo;
            // int.TryParse(string s, out int result)
            // bool test = int.TryParse(input, out number);
            if (int.TryParse(input, out number)) // returns bool
            {
                numberTwo = number;
            }


        }

        void IfElseStatement()
        {
            bool result = true;
            if (!result) // if result is not true
            {
                // do something
            } else // if result is true
            {
                // do something else
            }
        }

        void IfElseIfElseStatement()
        {
            bool result = true;
            bool test = false;
            if (!result) // if result is not true
            {
                // do something
            }
            else if(test) // if test is true
            {
                // do something else
            } else
            {
                // do something else
            }
        }

        void NestedIfStatements()
        {
            bool result = true;
            bool test = true;
            if (result)
            {
                if (test)
                {
                    // if both result and test are true, do something
                }
            }
        }

        void SwitchStatements()
        {
            int myInt = 2;
            switch (myInt)
            {
                case 0:
                    // do something
                    break;
                case 1:
                    // do something
                    break;
                case 2:
                    // do something
                    break;
                default: // this happens if all other cases fail
                    // do something
                    break;
            }

        }

    }
}
