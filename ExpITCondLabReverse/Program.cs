using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpITCondLabReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //assume the input will be as arguments
            //check for null input first
            if (args.Length < 1)
            {
                Console.WriteLine("Sorry, no arguments detected.");
            }
            else
            {
                //actual strings detected!
                //Console.WriteLine("Thank you for your input.");
                //Console.WriteLine();

                //reverse the first string, arg [0]
                //first challenge
                //taking advantage of the fact that strings are essentially character arrays
                string reverseFirst = new string(args[0].ToCharArray().Reverse().ToArray());
                Console.WriteLine("The reverse of the first string, '" + args[0] + "', is '" + reverseFirst + "'");
            }

            Console.WriteLine();    //whitespace
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
