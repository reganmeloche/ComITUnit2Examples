using System;
using System.Collections.Generic;

namespace MyFirstProject
{
    public class Lists
    {
        public static void Main()
        {   
            List<int> myList = new List<int>();

            // 1. Fill the list
            while (true) {
                Console.WriteLine("Enter the next number. Or enter 'quit' when you're done.");
                string userInput = Console.ReadLine();

                if (userInput == "quit") {
                    break;
                }

                int nextInt = Convert.ToInt32(userInput);
                myList.Add(nextInt);
            }


            // 2. Print the list
            PrintList(myList);

            // 3. Get max value from the list
            int max = GetMaxFromList(myList);

            Console.WriteLine("Max value of the list is: " + max);
        }

        static void PrintList(List<int> listToPrint) {
            Console.WriteLine("----------");
            for (int i = 0; i < listToPrint.Count; i++) {
                Console.WriteLine(listToPrint[i]);
            }
        }


        static int GetMaxFromList(List<int> someList) {
            int max = someList[0];
            for (int i = 0; i < someList.Count; i++) {
                if (someList[i] > max) {
                    max = someList[i];
                }
            }
            return max;
        }
    }
}