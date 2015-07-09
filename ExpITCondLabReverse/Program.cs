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
            //let the user know about that assumption
            Console.WriteLine("Project Reverse");
            Console.WriteLine("FYI this program expects to receive one or more arguments from the command line.");

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

                //first challenge
                //reverse the first string, arg [0]
                //taking advantage of the fact that strings are essentially character arrays
                string reverseFirst = new string(args[0].ToCharArray().Reverse().ToArray());
                Console.WriteLine("The reverse of the first string, '" + args[0] + "', is '" + reverseFirst + "'");
                Console.WriteLine();        //whitespace

                //Extra Credit
                //Reverse and print all the characters in all the arguments (array of strings)
                //first concatenate all the strings in the args array into one string, in regular order
                string allTheStringsCombined = "";      //initialize an empty string

                Console.Write("Input: ");  //prepare to show input as received
                foreach (string word in args)
                {
                    //concatenate each word in turn onto the end of the combined string
                    allTheStringsCombined = allTheStringsCombined + word;   
                    //Console.WriteLine(allTheStringsCombined);         //for debugging
                    Console.Write(word + " ");  //show the input strings one by one
                }
                Console.WriteLine();    //write a new line after the input strings have been printed
                Console.WriteLine();    //extra whitespace for readability
                //and now reverse it, just like above
                string reverseAll = new string(allTheStringsCombined.ToCharArray().Reverse().ToArray());
                Console.WriteLine("When the full combined string '" + allTheStringsCombined + "' is reversed,");
                Console.WriteLine("the result is '" + reverseAll + "'");
            }
            Console.WriteLine();    //whitespace
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
