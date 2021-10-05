using System;

namespace DevBuild_Lab_2_Number_Analyzer_Decision_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Prompt the user to Enter en integer between 1 and 100
            //2. Display the associated result based on the intger range entered
            //3. Use if/else statements to take different actions depending on user input
            //4. if the integer entered is odd, print the number entered and "odd"
            //5. if the integer entered is even and in the inclusive range of 2 to 25, print "Even and less then 25"
            //6. if the integer entered is even and in the inclusive range of 26 to 60, print "Even"
            //7. if the integer entered is even and greater than 60, print the number entered and "Even"
            //8. if the integer entered is odd and greater than 60, print the number entered and "Odd"
            //9. extra challanges: include a set of parameters so that the program ends officially, ask the user for info at the beginning of the app and use it to refer to them throughout the app.
            //10. another extra challange, add validation to guarantee that a user enters a positive integer between 1 and 100.

            string userAnswer;

            bool keepGoing = true;

            while(keepGoing == true)

            {
                string name;

                Console.WriteLine("Hello! What is your name?");
                name = Console.ReadLine();

                Console.WriteLine("We will play an odd/even number game!");
                Console.WriteLine(name + ", please enter a number between 1 and 100.");

    
                int number = int.Parse(Console.ReadLine());

                if (!(number >= 1 && number <= 99))
                {
                    Console.WriteLine("I am sorry, this is an invalid entry");
                    Console.WriteLine("Let's try this again");
                    break;
                }
                

                if (number % 2 == 1)
                {
                    Console.WriteLine(name + ", the entered number, " + number + " is Odd!");
                }
                else if (number >= 2 && number <= 25)
                {
                    Console.WriteLine(name + ", the entered number is even and less than 25.");
                }
                else if (number >= 26 && number <= 60)
                {
                    Console.WriteLine(name + ", the entered number is Even");
                }
                else if (number >= 60)
                {
                    Console.WriteLine(name + ", the entered number, " + number + " is Even");
                }
                else if (number >= 60)
                {
                    Console.WriteLine(name + ", the entered number, " + number + "is Odd");
                }
                else
                {
                    Console.WriteLine("I am sorry, that is an invalid entry!");
                }

                Console.WriteLine(name + ", would you like to continue entering numbers? Y/N");
                userAnswer = Console.ReadLine().ToLower();

                if (userAnswer == "y")
                {
                    Console.WriteLine("We will continue our game.");
                }
                else if(userAnswer == "n")
                {
                    Console.WriteLine(name + ", thank you for playing. Have a wonderful rest of your day!");
                    break;
                }
                else
                {
                    Console.WriteLine("I am sorry, that is an invalid entry!");
                    break;
                }

            }

           
        }
    }
}
