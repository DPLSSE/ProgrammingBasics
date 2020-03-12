using System;

namespace Exceptions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("*** EXCEPTIONS ***");

            // simulate a data input
            int input = 0;

            #region Exception

            DivideByMe(0);
            
            #endregion

            #region Caught

            //try
            //{
            //    DivideByMe(input);
            //}
            //catch (Exception ex)
            //{
            //    // return a message to the user
            //    Console.WriteLine("An error occurred: " + ex.Message);
            //}

            #endregion

            #region Avoided

            if (input != 0)
            {
                DivideByMe(input);
            }
            else
            {
                Console.WriteLine("Cannot divide by zero");
            }

            #endregion

            // Wait for user to hit a key before quitting
            Console.WriteLine("Hit any key to quit");
            Console.ReadKey();
        }

        static int DivideByMe(int denominator)
        {
            int numerator = 1;

            return numerator / denominator;
        }
    }
}
