using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "***** Homework_2_FizzBuzz *****";

            Console.WriteLine("The programm writes integers from 1 to 100.\n- for multiples of 3 prints Fizz\n- for the multiples of 5 prints Buzz\n- for multiples of both 3 and 5 prints FizzBuzz\n");

            CheckIfDividedByThreeOrFiveOrFifteen();

            Console.ReadLine();

        }

        static void CheckIfDividedByThreeOrFiveOrFifteen()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        WriteFizzBuzzToConsole(i);
                    }
                    else
                    {
                        WriteFizzToConsole(i);
                    }
                }
                else if (i % 5 == 0)
                {
                    WriteBuzzToConsole(i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void WriteFizzToConsole(int valueToWrite)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Fizz");
            Console.ResetColor();
        }

        static void WriteBuzzToConsole(int valueToWrite)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Buzz");
            Console.ResetColor();
        }

        static void WriteFizzBuzzToConsole(int valueToWrite)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("FizzBuzz");
            Console.ResetColor();
        }
    }
}
