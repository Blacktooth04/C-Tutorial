using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class TryCatch
    {
        private void Try()
        {
            string myString = "Nineteen";
            int myInt;

            // can use as many catches as necessary
            try
            {
                myInt = int.Parse(myString); 
                
            } catch (Exception) // replace Exception with proper exception, this instance would be format exception
            {
                Console.WriteLine("Must be a number");
            } finally
            {
                // run regardless rather of fail/pass
            }

        }

    }
}
