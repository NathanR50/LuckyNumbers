using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {




    
        static void Main(string[] args)
        {



            do
            {
                //Ask the user for a starting number for the lowest and ending number for the highest number in the number range

                Console.WriteLine("Today's jackpot is 1 Million !!! Please enter a starting number for the lowest number in a number range: ");
                int minNum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter an ending number for the highest number in a number range: ");
                int maxNum = Convert.ToInt32(Console.ReadLine());

                /*Ask the user to guess the 6 numbers the user thinks will be the lucky numbers generated within the number range.
                Numbers must be stored in an array
                Array must be populated using a loop
                If the user enters a number that is outside of the range set, prompt the user to give you a valid number.
                Do this until the user enters a valid number.
                 */

                Console.WriteLine("Guess the 6 numbers you think will be the lucky numbers generated within your number range.");

                int i;
                int[] luckyQuessNumbers = new int[6];
                for (i = 0; i < luckyQuessNumbers.Length; i++)
                {


                    luckyQuessNumbers[i] = Convert.ToInt32(Console.ReadLine());

                    if (luckyQuessNumbers[i] < minNum || luckyQuessNumbers[i] > maxNum)
                    {
                        Console.WriteLine("Please enter a valid number between your range:");
                        --luckyQuessNumbers[i];
                    }
                    /* else
                     {
                         Console.WriteLine("Thanks for entering the number " + luckyQuessNumbers[i]);
                     }
                     */
                    else
                    {
                        Console.WriteLine("Continue picking...");
                    }

                }


                /* The program should randomly generate 6 numbers "within the same range of numbers chosen by the user" using a loop
                The randomly generated numbers should be stored in an array
                Numbers should be displayed to the console as such and using a loop  */

                int[] randomNumbers = new int[6];

                Random randNum = new Random();
                for (int j = 0; j < randomNumbers.Length; j++)
                {
                    randomNumbers[j] = randNum.Next(minNum, maxNum);
                    int rand = randNum.Next(minNum, maxNum);

                    randomNumbers[j] = rand;
                    Console.WriteLine("Lucky Number: " + randomNumbers[j]);
                }


                //Comparing arrays for matching numbers

                int count = Convert.ToInt32(luckyQuessNumbers.Intersect(randomNumbers).Count());

                Console.WriteLine("You guessed " + count + " numbers correctly!");

                //The program should calculate the user's winnings based on the number of numbers guessed correctly.
                //e.g If the user correctly guessed 2 out of the 6 numbers correctly the program will calculate .33 of the total jackpot
                //the winnings.


                if (count == 6)
                {
                    Console.WriteLine("You won $1,000,000!");
                }
                else if (count == 5)
                {
                    Console.WriteLine("You won $250,000!");
                }
                else if (count == 4)
                {
                    Console.WriteLine("You won $50,000!");
                }
                else if (count == 3)
                {
                    Console.WriteLine("You won $5,000!");
                }
                else if (count == 2)
                {
                    Console.WriteLine("You won $500!");
                }
                else if (count == 1)
                {
                    Console.WriteLine("You won $5!");
                }
                else
                {
                    Console.WriteLine("You are not a winner.");
                }

                /*
                 * Ask the user if the user would like to play again.
                 If the user says yes, then the program should run again from the beginning.
                 If the user says no, then the program should say "Thanks for playing!" (Must be exact statement) */

                Console.WriteLine("Would you like to play again?");

                string answer = Convert.ToString(Console.ReadLine());
                //bool result = answer.ToLower() == "no"

                if (answer.ToLower() == "no")
                {
                    Console.WriteLine("Thank you for playing!");
                    Environment.Exit(0);

                }


            }

            while (true);





        }
    }
}
