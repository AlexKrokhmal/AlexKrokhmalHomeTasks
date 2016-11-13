using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_2___FizzBuzz_2
{
    class SecondTry
    {
        static void Main(string[] args)
        {

            int counter = 1;
            int divideBy15Result = 0;

            while (counter <= 100)
            {
                divideBy15Result = ModuleBy15(counter);

                switch (divideBy15Result)
                {
                    case 3:
                    case 6:
                    case 9:
                    case 12:
                        Console.WriteLine("Fizz");
                        break;
                    case 5:
                    case 10:
                        Console.WriteLine("Buzz");
                        break;
                    case 0:
                        Console.WriteLine("FizzBuzz");
                        break;
                    default:
                        Console.WriteLine(counter);
                        break;
                }

                counter++;
            }

            Console.ReadKey();
        }

        public static int ModuleBy15(int incomingValueToBeDivided)
        {
            int moduleBy15Result = incomingValueToBeDivided % 15;
            return moduleBy15Result;
        }

    }

}
