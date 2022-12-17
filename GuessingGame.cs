//Filename: GuessingGame.cs
//Purpose: Generates_A_Number_Between_1_And_10 
//Programmer: Roger Generelly 02/28/22 

using System;
using static System.Console;
class GuessingGame 
{

    static void Main()
    {
Random ranNumberGenerator = new Random();
int randomNumber;
int min = 1;
int max = 10;
randomNumber = ranNumberGenerator.Next(min, max);
string inputString;
int number;
Write("Guess a Number between 1 and 10>> ");
inputString = ReadLine();
number = Convert.ToInt32(inputString);
WriteLine("The secret number is {0}.", randomNumber);
if (number == randomNumber)
        {
        WriteLine("Your Guess is correct");
        }
    else if (number > randomNumber) 
            {
            WriteLine("Your Guess is too high");
            }
        else if (number < randomNumber)
                {
                WriteLine("Your Guess is too low");
                }
    
}
    }




