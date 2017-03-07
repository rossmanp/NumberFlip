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
                Console.WriteLine("Whoops! You did not input an integer. Please press enter to quit the program and restart it.");
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

            foreach (var num in digits)
                Console.Write(num);
            Console.ReadLine();
        }
    }
}
