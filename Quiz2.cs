using System;
using System.Collections.Generic;

namespace MyFirstProject
{
    public class Unit2Quiz2 
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

