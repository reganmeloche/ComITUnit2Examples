using System;

namespace MyFirstProject
{
    public class DecimalBinary
    {
        public static void Run()
        {
            Console.WriteLine("Please enter a base-10 number: ");
            string userInput = Console.ReadLine();
            int decimalNumber = Convert.ToInt32(userInput);
            string binaryString = ConvertDecimalToBinary(decimalNumber);
            Console.WriteLine("The result is: " + binaryString);
        }

        static string ConvertDecimalToBinary(int num) {
            string result = "";

            while (num > 0) {
                if (num % 2 == 0) {
                    result += "0";
                } else {
                    result += "1";
                }
                num /= 2;
            }

            // Reverse the string
            string reversedResult = ""; 
            for (int i = result.Length-1; i >= 0; i--) {
                reversedResult += result[i];
            }
            return reversedResult;
        }
    }
}