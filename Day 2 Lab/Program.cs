using System;

namespace Day_2_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string ending;
            bool runProgram = true;
            do
            {
                Console.WriteLine("What is your name?");//collect user name
                string name = Console.ReadLine();
                while (true)
                {
                    Console.WriteLine("Please enter a number between 1 and 100");//collect number input
                    int choice = int.Parse(Console.ReadLine());

                    if (choice % 2 != 0 && choice <= 100)//choice is odd
                    {
                        Console.WriteLine($"{name} {choice} is odd");
                        break;
                    }
                    else if (choice % 2 == 0 && choice >= 2 && choice <= 25)//choice is even and less than 25
                    {
                        Console.WriteLine($"{name} {choice} is even and less than 25");
                        break;
                    }
                    else if (choice % 2 == 0 && choice >= 26 && choice <= 60)//choice is even and between 25 and 60
                    {
                        Console.WriteLine($"{name} is even");
                        break;
                    }
                    else if (choice % 2 == 0 && choice >= 60 && choice < 100)//choice is even and greater than 60
                    {
                        Console.WriteLine($"{name} {choice} is even");
                        break;
                    }
                    else if (choice <= 0 || choice > 100)
                    {
                        Console.WriteLine("Invalid input.  Please select a number between 1 and 100");
                        continue;
                    }
                }
                Console.WriteLine("Would you like to enter another number? y/n");
                ending = Console.ReadLine();
                if (ending == "y")
                {
                    continue;
                } if (ending == "n")
                {
                    runProgram = false;
                    Console.WriteLine($"Bye now {name}!!");
                }
            } while (runProgram);
        }
    }
}
