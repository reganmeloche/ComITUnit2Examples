using System;
using System.Collections.Generic;

namespace MyFirstProject
{
    class CityNames 
    {
        public static void Run()
        {   
            List<string> cities = new List<string>();

            // Gather input
            for (int i = 0; i < 5; i++) {
                Console.WriteLine("Please enter a city name: ");
                string userInput = Console.ReadLine();

                if (userInput.Length >= 3 && userInput.Length <= 30) {
                    cities.Add(userInput);
                } else {
                    Console.WriteLine("Invalid city length");
                }
            }

            // Print the list
            Console.WriteLine("-----------------------");
            for (int i = 0; i < cities.Count; i++) {
                Console.WriteLine(cities[i]);
            }
            
        }

    }
}

