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

        // Function
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
            return ReverseString(result);
        }

        static string ReverseString(string stringToReverse) {
            string reversedResult = ""; 
            for (int i = stringToReverse.Length-1; i >= 0; i--) {
                reversedResult += stringToReverse[i];
            }
            return reversedResult;
        }
    }
}