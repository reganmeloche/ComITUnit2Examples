using System;

namespace MyFirstProject
{
    public class QuizHint
    {
        public static void Run() {

            int age = 11;
            decimal ticketPrice = 0m;

            // If statements go here
            if (age < 5) {
                ticketPrice = 0m;
            } else if (age >= 5 && age < 14) {
                ...
            }...
            
        
            Console.WriteLine("The ticket price is: " + ticketPrice);
        }
    }
}
