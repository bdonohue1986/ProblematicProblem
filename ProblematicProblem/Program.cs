using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;


namespace ProblematicProblem
{
    public class Program
    {


        static string cont = "yes";


        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
        static void Main(string[] args)
        {


            var random = new Random();

            Console.WriteLine("Welcome to the random activity generator. Would you like to get an activity? yes/no");
            Console.WriteLine();

            var cont = (Console.ReadLine().ToLower());
            Console.WriteLine();

            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("What is your age? ");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Would you like to see the current list of activities? Sure/No ");
            var seeList = Console.ReadLine().ToLower();
         

            if (seeList == "sure" || seeList == "yes")
            {
                foreach (string activity in activities)
                {
                   
                    Console.Write($"{activity} ");
                    Thread.Sleep(500);
                    
                }
            }
            Console.WriteLine();

            Console.Write("Would you like to add any activities before we generate one? yes/no: ");
            var addToList = Console.ReadLine();
            Console.WriteLine();
            while (addToList == "yes")
            {
                Console.Write("What would you like to add? ");
                string userAddition = Console.ReadLine();
                activities.Add(userAddition);

            }




            if (cont == "yes")
            {

                Console.Write("Connecting to the database");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }
                Console.WriteLine();
                Console.Write("Choosing your random activity");
                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }
                Console.WriteLine();
                int randomNumber = random.Next(activities.Count);
                string randomActivity = activities[randomNumber];
                if (userAge < 21 && randomActivity == "Wine Tasting")
                {
                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    Console.WriteLine("we will remove that from the list");
                    activities.Remove(randomActivity);
                    int randomNumber1 = random.Next(activities.Count);
                    string randomActivity1 = activities[randomNumber1];


                }



                Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! ");
                Console.WriteLine();
                Console.WriteLine($"{userName} thank you for your time feel free to play again when ready. Now go do some {randomActivity}!");
            }


                    if (cont == "no")
                    {
                        Console.WriteLine($"{userName} thank you for your time feel free to play when ready!");

                    }
                
            
        }
    }
}