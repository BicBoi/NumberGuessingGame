using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace numberguessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess;
            int a = 1;
            int b = 100;
            string input;
            int counter = 1;

            Console.WriteLine("Think of a number between 1 and 100.");

            while (counter <= 7)
            {
                guess = (a + b) / 2;
                Console.WriteLine("Is your number {0}?", guess);
                Console.WriteLine("h, l, or e");
                input = Console.ReadLine();
                if (input == "h")
                {
                    a = guess + 1;
                }
                if(input == "l")
                {
                    b = guess - 1;
                }
                if(input == "e")
                {
                    break;
                }
                counter++;
            }

        }
    }
}
