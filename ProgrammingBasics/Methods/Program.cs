using System;

namespace Methods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*** METHODS ***");

            Console.WriteLine("Press your favorite key");
            ConsoleKeyInfo keyInfo = Console.ReadKey(); // Returns the value of the pressed key
            WriteResult(keyInfo.Key.ToString());
            
            Console.WriteLine("Type something and press return");
            string lineInfo = Console.ReadLine(); // Returns the line of text after hitting return
            WriteResult(lineInfo);
        }

        public static void WriteResult(string input)
        {
            string result = FormatResult(input);
            Console.WriteLine(result); // returns the result to the console
        }

        public static string FormatResult(string input)
        {
            return "You typed " + input;
        }
    }
}
