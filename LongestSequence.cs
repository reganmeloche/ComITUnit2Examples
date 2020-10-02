using System;

namespace MyFirstProject
{
    public class LongestSequence
    {
        public static void Run() {
            string str = "11122";

            if (str.Length == 0) {
                Console.WriteLine("No string was entered");
                return;
            }
            
            char newDigit = str[0];
            char currentRunValue = newDigit;
            int currentRunLength = 1;
            int maxRun = 1;

            for (int i = 0; i < str.Length; i++) {
                newDigit = str[i];
                if (newDigit == currentRunValue) {
                    currentRunLength++;
                } else {
                    currentRunLength = 1;
                    currentRunValue = newDigit;
                }

                if (currentRunLength > maxRun) {
                    maxRun = currentRunLength;
                }
            }

            Console.WriteLine("Max run is: " + maxRun);
        }
    }
}