using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    public class Guess
    {
        public int SecretNumber { get; set; }

       

        public void GuessGame(int secretNumber)
        {
            Random number = new Random();
            secretNumber = 0;
            int myGuess = 0;
            int count = 1;
            ArrayList guessList = new ArrayList();

            secretNumber = number.Next(1, 11);

            while (count < 10)
            {

                Console.WriteLine("Guess A Number");

                myGuess = Convert.ToInt32(Console.ReadLine());

                if (!guessList.Contains(myGuess))
                {
                    guessList.Add(myGuess);

                }


                if (myGuess < 0 || myGuess > 10)
                {
                    Console.WriteLine("Enter a number between 1 - 10 ");
                }

                else if (myGuess > secretNumber)
                {
                    Console.WriteLine("Too high!!");
                }

                else if (myGuess < secretNumber)
                {
                    Console.WriteLine("Too low!!");
                }

                else
                {
                    Console.WriteLine($"Yeaaaaaaaahh!!! Secret Number = {secretNumber}");
                    Console.WriteLine("You had 10 tries");
                    Console.WriteLine($"You got it on guess number {guessList.Count}");
                    break;
                }

                count++;

            }
        }
    }

   
}
