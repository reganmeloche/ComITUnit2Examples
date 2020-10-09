using System;
using System.Collections.Generic;

namespace MyFirstProject
{
    class Unit2Quiz2 
    {

        public static void Q2() {
        
        }
        public static void Q3() {
        
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



        // public static void Main()
        // {   
        //     var ingredients = new List<string>() { "garlic", "onions" };
        //     ingredients.Add("noodles");
        //     AddTheSauce(ingredients);
        //     ingredients.Add("cilantro");

        //     Console.WriteLine("Add the secret ingredient:");
        //     string secretIngredient = Console.ReadLine();
        //     ingredients.Add(secretIngredient);

        //     Console.WriteLine("This recipe has " + ingredients.Count + " ingredients.");
        // }

        // static void AddTheSauce(List<string> theList) {
        //     theList.Add("fish sauce");
        //     theList.Add("peanut butter");
        //     theList.Add("rice vinegar");
        // }


                    // // 1 1 2 3 5 8 13 21
            // // 0 1 2 3 4 5 6  7
            // Console.WriteLine("Which fibonacci value would you like to find?");
            // string userInput = Console.ReadLine();
            // int n = Convert.ToInt32(userInput);

            // var fib = new List<int>();
            // fib.Add(1);
            // fib.Add(1);

            // for (int i = 2; i <= n; i++) {
            //     int next = fib[i-1] + fib[i-2];
            //     fib.Add(next);
            // }

            // Console.WriteLine(fib[n]);

        static string DoIt(int n, bool b) {
            string s = "";
            for (int i = 0; i < n; i++) {
                if (b) {
                    s += ".";
                } else {
                    s += "-";
                }
            }

            return s;
        }
    }
}

