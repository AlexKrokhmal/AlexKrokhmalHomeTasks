using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaks1
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstEnteredValue = 0, secondEnteredValue = 0;
            bool tryPasreResult = true, doYouWantToRepeat = false;

            Console.Title = "This program allows to check whether integer A is a divider of integer B";
            
            Console.WriteLine("***** Hello. This program allows to enter two integers and verify if the second (B) is a divider of the first one (A) *****\n");

            //Allows to repeat all the flow with new numbers if user wants
            do
            {
                //Ask to enter 1st number, read it, check if it is an integer, ask to re-enter if it is not.
                do
                {
                    Console.WriteLine("Plese, enter the first integer (A) and press Enter.");

                    tryPasreResult = true;

                    if (!Int32.TryParse(Console.ReadLine(), out firstEnteredValue))
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine("\nYou have entered not a valid value.\nOnly interes from range [-2 147 483 648; +2 147 483 647] are supported.\n");
                        tryPasreResult = false;

                        Console.ResetColor();
                    }                                        

                } while (!tryPasreResult);
                
                Console.WriteLine("{0} accepted", firstEnteredValue);

                //Check if the firts value is "0". If yes, no need to proceed (any number is a divider of "0")
                if (firstEnteredValue == 0)
                {
                    Console.WriteLine("You don't need to enter the second integer, I already know the answer - any number is a divider of '0'. ;)");
                }
                else
                {
                    //Ask to enter 2nd number, read it, check if it is an integer, ask to re-enter if it is not.
                    do
                    {
                        Console.WriteLine("Plese, enter the second integer (B) and press Enter.");

                        tryPasreResult = true; //not mandatory. Can be removed 

                        if (!Int32.TryParse(Console.ReadLine(), out secondEnteredValue))
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.WriteLine("\nYou have entered not a valid value.\nOnly interes from ranges [-2 147 483 648; 0), (0; +2 147 483 647] are supported.\n");
                            tryPasreResult = false;

                            Console.ResetColor();
                        }

                        //Check if the 2nd value is a '0'. If yes, make 'tryPasreResult' false, so user will be asked to enter it again
                        else if (secondEnteredValue == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.WriteLine("\nError: Cannot divide by '0'\nOnly interes from ranges [-2 147 483 648; 0), (0; +2 147 483 647] are supported.\n");
                            tryPasreResult = false;

                            Console.ResetColor();
                        }

                    } while (tryPasreResult == false);

                    Console.WriteLine("{0} accepted", secondEnteredValue);

                    Console.WriteLine("\n**************\n\nResult:");

                    if (firstEnteredValue % secondEnteredValue == 0)
                    {
                        Console.WriteLine("The second integer is a divider of the first one.\n");
                    }
                    else
                    {
                        Console.WriteLine("The second integer is NOT a divider of the first one.\n");
                    }
                }
                

                Console.WriteLine("\n-----------------------------------------------\n\nIf you want to repeat, please enter 'y'.");

                if (Console.ReadLine() == "y")
                {
                    doYouWantToRepeat = true;
                    Console.WriteLine();
                }
                else
                {
                    doYouWantToRepeat = false;
                }

            } while (doYouWantToRepeat);
                        
        }
    }
}
