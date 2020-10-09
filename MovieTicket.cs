using System;

namespace MyFirstProject
{
    public class MovieTicket
    {
        static void Run()
        {
            Console.WriteLine("Welcome to the ComIT movie theatre!");
            Console.WriteLine("Please enter your age:");
            string userInput = Console.ReadLine();

            int age = Convert.ToInt32(userInput);

            if (age < 0 || age > 130) {
                Console.WriteLine("Invalid age. Please try again.");
                return;
            }

            double price = 0.0;

            if (age <= 5) {
                price = 0.0;
            } 
            else if (age >= 6 && age <= 14) {
                price = 7.99;
            } 
            else if (age >= 15 && age <= 64) {
                price = 11.99;
            }
            else {
                price = 9.99;
            }

            // If day is tuesday, then cut the price in half
            DateTime currentDate = DateTime.Now;
            if (currentDate.DayOfWeek == DayOfWeek.Tuesday) {
                price /= 2;
            }

            double roundedPrice = Math.Round(price, 2);
            Console.WriteLine("The movie ticket price is: " + roundedPrice);
        }
    }
}