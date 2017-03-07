using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Program: Number Flip
//Developer: Pete Rossman
//This program takes an integer as input and reverses the order
//of the digits in the integer.
namespace NumberFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer to have it reversed:");
            //Take an integer argument from the console, put it into the string "input",
            //and have it converted into the integer "myNum" using the Int32.TryParse method.
            string input = Console.ReadLine();
            int myNum;
            Int32.TryParse(input, out myNum);
            // If an integer is not input, the following if loop will tell the user and end the program.
            if (!Int32.TryParse(input, out myNum))
                {
                Console.WriteLine("Whoops! You did not input an integer.");
                Console.WriteLine("Press enter to end the program.");
                Console.ReadLine();
                Environment.Exit(0);
                }
            //Create a list "digits" to place the digits of the integer.
            List<int> digits = new List<int>();
            //The while loop uses Math.DivRem to separate the inputted integer into digits.
            //It takes the integer, divides it by 10, takes the remainder andd stores it in
            //the list "digits". This process repeats until all the digits of the inputted
            //integer have been stored.
            while (myNum > 0)
            {
                int digit;
                myNum = Math.DivRem(myNum, 10, out digit);
                digits.Add(digit);
            }
            //The following lines print the reversed integer and then end the program.
            Console.WriteLine("Your reversed integer is: ");
            foreach (var num in digits)
                Console.Write(num);
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to end the program.");
            Console.ReadLine();
        }
    }
}
