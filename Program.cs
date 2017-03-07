using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer to have it reversed:");
            string input = Console.ReadLine();
            int myNum;
            Int32.TryParse(input, out myNum);
            if (!Int32.TryParse(input, out myNum))
                {
                Console.WriteLine("Whoops! You did not input an integer.");
                Console.WriteLine("Press enterto end the program.");
                Console.ReadLine();
                Environment.Exit(0);
                }
            List<int> digits = new List<int>();
            while (myNum > 0)
            {
                int digit;
                myNum = Math.DivRem(myNum, 10, out digit);
                digits.Add(digit);
            }
            Console.WriteLine("Your reversed integer is: ");
            foreach (var num in digits)
                Console.Write(num);
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to end the program.");
            Console.ReadLine();
        }
    }
}
