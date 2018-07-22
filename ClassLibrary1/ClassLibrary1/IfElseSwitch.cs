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
         * https://www.geeksforgeeks.org/switch-vs-else/
         * 
         * If-else conditional branches are great for variable conditions 
         * that result into a boolean, whereas switch statements are 
         * great for fixed data values.
         * 
         * A switch statement might prove to be faster than ifs provided 
         * number of cases are good. If there are only few cases, it 
         * might not effect the speed in any case. Prefer switch if the 
         * number of cases are more than 5 otherwise, you may use if-else 
         * too. If a switch contains more than five items, it’s 
         * implemented using a lookup table or a hash list. This means 
         * that all items get the same access time, compared to a list of 
         * if:s where the last item takes much more time to reach as it 
         * has to evaluate every previous condition first.
         * 
         * When compiler compiles a switch statement, it will inspect each 
         * of the case constants and create a “jump table” that it will use 
         * for selecting the path of execution depending on the value of 
         * the expression. Therefore, if we need to select among a large 
         * group of values, a switch statement will run much faster than 
         * the equivalent logic coded using a sequence of if-elses. The 
         * compiler can do this because it knows that the case constants 
         * are all the same type and simply must be compared for equality 
         * with the switch expression, while in case of if expressions, the 
         * compiler has no such knowledge.
         * 
         * **/


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

        void ReplaceIfElseWithConditionals()
        {
            /**
             * Conditional statements
             * if value is true, the first statment, else the second statement.
             * valueToEvaluate ? ifTrue : ifFalse;
             * **/

            bool result = true;
            bool solution;
            if (!result) // if result is not true
            {
                solution = true;
            }
            else // if result is true
            {
                solution = false;
            }
            // BECOMES
            solution = !result ? true : false;

            result = true;
            bool test = false;
            string solution2;

            if (!result) // if result is not true
            {
                solution2 = "true";
            }
            else if (test) // if test is true
            {
                solution2 = "false";
            }
            else
            {
                solution2 = "invalid";
            }
            // BECOMES
            solution2 = !result ? "true" : test ? "false" : "invalid";

        }

        /**
         * SWITCH STATEMENTS
         * 
         * **/

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
