using System;

namespace Session2._3Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string theString = "string";
            int theInt = 1;
            char theChar = 'a';
            bool theBool = true;
            double theDouble = 1.1;
            decimal theDecimal = 1.1m;

            Console.WriteLine($"I have {theChar} piece of {theString} " +
                $"and it is {theInt} meter long. True? {theBool}. " +
                $"A double is {theDouble} and a decimal is {theDecimal}.");
        }
    }
}
