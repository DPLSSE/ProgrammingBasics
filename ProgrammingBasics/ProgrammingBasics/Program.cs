using System;

namespace ProgrammingBasics
{
    class MainClass
    {
        public static void Main()
        {

            //Variables();
            //Constants();
            //DataTypes();

            //ArithmeticOperations();
            //OrderOfOperations();
            //ComparisonOperations();
            //LogicalOperations();

            //StandardIO();

            //SequenceStructure();
            //IfStatement();
            //IfElseStatement();
            //IfElseIfStatement();
            //NestedIfStatement();
            SwitchStatement();

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
            Console.WriteLine("*** STANDARD IO ***");

            Console.WriteLine("Press your favorite key"); // Writes the string to console
            ConsoleKeyInfo keyInfo = Console.ReadKey(); // Returns the value of the pressed key
            Console.WriteLine("You pressed " + keyInfo.Key.ToString());

            Console.WriteLine("Type something and press return");
            string lineInfo = Console.ReadLine(); // Returns the line of text after hitting return
            Console.WriteLine("You entered " + lineInfo);
        }

        // References
        // https://www.hunker.com/13416128/recommended-humidity-based-on-the-temperature-in-the-house
        // https://www.pkwadsworth.com/blog/whats-the-proper-humidity-level-for-your-home-in-winter

        public static void SequenceStructure()
        {
            Console.WriteLine("*** SEQUENCE STRUCTURE ***");

            Console.WriteLine("Enter the current temperature in Fahrenheit");
            string enteredTemp = Console.ReadLine();

            int fahrenheitTemp;
            int.TryParse(enteredTemp, out fahrenheitTemp);

            int celsiusTemp = (fahrenheitTemp - 32) * 5 / 9;

            Console.WriteLine("The current temp in celsius is " + celsiusTemp);
        }

        public static void IfStatement()
        {
            Console.WriteLine("*** IF STATEMENT ***");

            Console.WriteLine("Enter the current temperature in Fahrenheit");
            string enteredTemp = Console.ReadLine();

            int fahrenheitTemp;
            bool isInt = int.TryParse(enteredTemp, out fahrenheitTemp);

            if (isInt) // Only do the calculation if the data entered is an integer
            {
                int celsiusTemp = (fahrenheitTemp - 32) * 5 / 9;

                Console.WriteLine("The current temp in celsius is " + celsiusTemp);
            }
        }

        public static void IfElseStatement()
        {
            Console.WriteLine("*** IF-ELSE STATEMENT ***");

            Console.WriteLine("Enter the current temperature in Fahrenheit");
            string enteredTemp = Console.ReadLine();

            int fahrenheitTemp;
            bool isInt = int.TryParse(enteredTemp, out fahrenheitTemp);

            if (isInt) // Only do the calculation if the data entered is an integer
            {
                int celsiusTemp = (fahrenheitTemp - 32) * 5 / 9;

                Console.WriteLine("The current temp in celsius is " + celsiusTemp);
            }
            else
            {
                Console.WriteLine("You did not enter a valid number");
            }
        }

        public static void IfElseIfStatement()
        {
            Console.WriteLine("*** IF-ELSE-IF STATEMENT ***");

            Console.WriteLine("Enter the current temperature in Fahrenheit");
            string enteredTemp = Console.ReadLine();

            int fahrenheitTemp;
            bool isInt = int.TryParse(enteredTemp, out fahrenheitTemp);

            if (fahrenheitTemp >= 20)
            {
                Console.WriteLine("Ideal humidity is 50%");
            }
            else if ((fahrenheitTemp < 20) & (fahrenheitTemp >= 10))
            {
                Console.WriteLine("Ideal humidity is 35%");
            }
            else // Temperature is less than 10 degrees
            {
                Console.WriteLine("Ideal humidity is 30%");
            }
        }

        public static void NestedIfStatement()
        {
            Console.WriteLine("*** NESTED IF STATEMENT ***");

            Console.WriteLine("Enter the current temperature in Fahrenheit");
            string enteredTemp = Console.ReadLine();

            int fahrenheitTemp;
            bool isInt = int.TryParse(enteredTemp, out fahrenheitTemp);

            if (isInt) // Only do the calculation if the data entered is an integer
            {
                if (fahrenheitTemp > 40)
                {
                    Console.WriteLine("Ideal humidity is 50%");
                }
                else
                {
                    Console.WriteLine("Ideal humidity is 35%");
                }
            }
            else
            {
                Console.WriteLine("You did not enter a valid number");
            }
        }

        public static void SwitchStatement()
        {
            Console.WriteLine("*** SWITCH STATEMENT ***");

            Console.WriteLine("Enter the number for the current season");
            Console.WriteLine("1 = Winter");
            Console.WriteLine("2 = Spring");
            Console.WriteLine("3 = Summer");
            Console.WriteLine("4 = Fall");
            string currentSeason = Console.ReadLine();

            switch (currentSeason)
            {
                case "1":
                    Console.WriteLine("Set humidity to 30% for Winter");
                    break;
                case "2":
                    Console.WriteLine("Set humidity to 40% for Spring");
                    break;
                case "3":
                    Console.WriteLine("Set humidity to 50% for Summer");
                    break;
                case "4":
                    Console.WriteLine("Set humidity to 35% for Fall");
                    break;
                default:
                    Console.WriteLine("You did not enter a valid season");
                    break;
            }
        }
    }
}
