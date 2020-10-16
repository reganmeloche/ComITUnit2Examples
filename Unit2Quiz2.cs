using System;
using System.Collections.Generic;

namespace MyFirstProject
{
    public class Unit2Quiz2 
    {

        /*
        Write a function that takes in two numbers, and returns the sum of all of the numbers between and including those two numbers. 
        Example: I enter 7 and 12 - the result should be 57 (7+8+9+10+11+12 = 57)
        */
        public static int Q2(int a, int b) {
            int min = Math.Min(a,b);
            int max = Math.Max(a,b);

            int sum = 0;
            for (int i = min; i <= max; i++) {
                sum += i;
            }
            return sum;
        }

        public static string Q3(string input) {
            string newString = "";

            List<string> vowels = new List<string>() {"a", "e", "i", "o", "u"};

            for (int i = 0; i < input.Length; i++) {
                string nextChar = input[i].ToString();
                string nextCharLower = nextChar.ToLower();

                if (!vowels.Contains(nextCharLower)){
                    newString += nextChar;
                }
            }

            return newString;
        }

        public static void Q5() {
            int a = 1;
            FuncA(a);

            int b = 2;
            b = FuncB(b);

            var c = new List<int>() { 8, -9, 12 };
            c.Add(15);
            FuncC(c);

            var d = new List<int>() { -5, 6, 4 };
            FuncD(d);

            var e = new List<int>() { 7, 12, -33 };
            FuncE(e);
            
            Console.WriteLine(a);
            Console.WriteLine(b);
            PrintList(c);
            PrintList(d);
            PrintList(e);
        }

        static void PrintList(List<int> myList) {
            for (int i = 0; i < myList.Count; i++) {
                Console.Write($"{myList[i]} ");
            }
            Console.WriteLine();
        }

        static void FuncA(int x) {
            x++;
        }
        static int FuncB(int x) {
            x++;
            return x;
        }
        static void FuncC(List<int> x) {
            x.Add(49);
        }
        static void FuncD(List<int> x) {
            var temp = new List<int>();
            temp = x;
            temp.Add(5);
        }
        static void FuncE(List<int> x) {
            var temp = new List<int>();
            for (int i = 0; i < x.Count; i++) {
                temp.Add(x[i]);
            }
            temp.Add(4);
        }
    }
}

