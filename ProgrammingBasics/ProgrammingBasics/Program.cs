using System;

namespace ProgrammingBasics
{
    class MainClass
    {
        public static void Main()
        {
            Variables();

            Constants();

            DataTypes();

            ArithmeticOperations();

            OrderOfOperations();

            ComparisonOperations();

            LogicalOperations();

            StandardIO();

            // Wait for user to hit a key before quitting
            Console.WriteLine("Hit any key to quit");
            Console.ReadKey();
        }

        public static void Variables()
        {
            Console.WriteLine("*** VARIABLES ***");

            // Declaring a variable
            int myInteger;

            // Assigning a value to a variable
            myInteger = 1;

            Console.WriteLine("myInteger = " + myInteger);

            // Combining declaration and assignment
            int myOtherInteger = 2;

            Console.WriteLine("myOtherInteger = " + myOtherInteger);
        }

        public static void Constants()
        {
            Console.WriteLine("*** CONSTANTS ***");

            // Declaring a constant
            const int myConstant = 3;

            Console.WriteLine("myConstant = " + myConstant);

        }

        public static void DataTypes()
        {
            Console.WriteLine("*** DATA TYPES ***");

            // Declarations
            int myInteger = 10;
            long myLong = 3000000000;
            double myDouble = 3.14159;
            decimal myDecimal = 5.99m;

            bool myBoolean = false;

            char myChar = 'D';

            string myString = "Software";

            Console.WriteLine("myInteger = " + myInteger);
            Console.WriteLine("myLong = " + myLong);
            Console.WriteLine("myDouble = " + myDouble);
            Console.WriteLine("myDecimal = " + myDecimal);
            Console.WriteLine("myBoolean = " + myBoolean);
            Console.WriteLine("myChar = " + myChar);
            Console.WriteLine("myString = " + myString);
        }

        public static void ArithmeticOperations()
        {
            Console.WriteLine("*** ARITHMETIC OPERATIONS ***");

            int myInt1 = 1;
            int myInt5 = 5;
            int myInt7 = 7;
            int myInt10 = 10;
            int myInt13 = 13;
            int result;

            result = myInt1 + myInt5; // Result = 6
            Console.WriteLine(result);

            result = myInt1 - myInt5; // Result = -4
            Console.WriteLine(result);

            result = myInt5 * myInt7; // Result = 35
            Console.WriteLine(result);

            result = myInt10 / myInt5; // Result = 2
            Console.WriteLine(result);

            result = myInt13 % myInt7; // Result = 6
            Console.WriteLine(result);

            myInt1++; // myInt1 = 2
            Console.WriteLine(myInt1);

            myInt1--; // myInt1 = 1
            Console.WriteLine(myInt1);
        }

        public static void OrderOfOperations()
        {
            Console.WriteLine("*** ORDER OF OPERATIONS ***");

            int myInt3 = 3;
            int myInt5 = 5;
            int myInt7 = 7;
            int myInt13 = 13;
            int result;

            result = myInt5 - myInt7 * (myInt5 + myInt3) + myInt13; // result = -38;
            Console.WriteLine(result);
        }

        public static void ComparisonOperations()
        {
            Console.WriteLine("*** COMPARISON OPERATIONS ***");

            int myInt1 = 1;

            Console.WriteLine(myInt1 == 1); // True
            Console.WriteLine(myInt1 != 1); // False
            Console.WriteLine(myInt1 < 2); // True
            Console.WriteLine(myInt1 <= 1); // True
            Console.WriteLine(myInt1 > 1); // False
            Console.WriteLine(myInt1 >= 1); // True
        }

        public static void LogicalOperations()
        {
            Console.WriteLine("*** LOGICAL OPERATIONS ***");

            int myInt3 = 3;
            int myInt5 = 5;
            int myInt7 = 7;
            bool result;

            result = (myInt5 > myInt7) & (myInt5 > myInt3); // result = False;
            Console.WriteLine(result);
            result = (myInt5 > myInt7) | (myInt5 > myInt3); // result = True;
            Console.WriteLine(result);
            result = !(myInt5 > myInt7); // result True
            Console.WriteLine(result);
        }

        public static void StandardIO()
        {
            Console.WriteLine("Press your favorite key"); // Writes the string to console
            ConsoleKeyInfo keyInfo = Console.ReadKey(); // Returns the value of the pressed key
            Console.WriteLine("You pressed " + keyInfo.Key.ToString());

            Console.WriteLine("Type something and press return");
            string lineInfo = Console.ReadLine(); // Returns the line of text after hitting return
            Console.WriteLine("You entered " + lineInfo);
        }
    }
}
