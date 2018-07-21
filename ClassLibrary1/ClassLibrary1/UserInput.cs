using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class UserInput
    {
        private void requestInput()
        {
            // use system.diagnostics to run in class Library
            //System.Diagnostics.Debug.WriteLine("What is your name?");
            Console.WriteLine("What is your name?");
            string input = Console.ReadLine();
            Console.WriteLine("Hello " + input + ".");
        }
    }
}
