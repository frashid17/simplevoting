using System;
using System.ComponentModel.DataAnnotations;

namespace VotingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // Loop to allow multiple voters to input their choices
            {
                Console.WriteLine("Input Your Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Input your Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                const int reqage = 18;

                if (age < reqage)
                {
                    Console.WriteLine(name + ", You are not allowed to vote. Please wait for " + (reqage - age) + " more years.");
                }
                else
                {
                    Console.WriteLine("Choose your candidate: Patrick(1) or Mwangi(2)");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Mr. " + name + ", You have selected Patrick as your candidate.");
                            break;
                        case 2:
                            Console.WriteLine("Mr. " + name + ", You have selected Mwangi as your candidate.");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please choose either 1 or 2.");
                            break;
                    }
                }

                Console.WriteLine("Do you want to continue voting? (yes/no)");
                string continueVoting = Console.ReadLine().ToLower();

                if (continueVoting != "yes")
                {
                    break; // Exit the loop if the user doesn't want to continue voting
                }
            }
        }
    }
}
