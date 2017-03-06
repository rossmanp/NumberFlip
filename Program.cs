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
            int myNum = 321;
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
