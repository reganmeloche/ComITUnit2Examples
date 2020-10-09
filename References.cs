using System;

namespace MyFirstProject
{
    class References 
    {
        public static void Run()
        {   
            int a = 4;
            int b = 4;
            Console.WriteLine(a == b);
            MyIntFunction(a);
            Console.WriteLine(a);

            string s1 = "test";
            string s2 = "test";
            Console.WriteLine(s1 == s2);
            MyStringFunction(s1);
            Console.WriteLine(s1);

            int[] a1 = {1,2,3};
            int[] a2 = {1,2,3};
            Console.WriteLine(a1 == a2); 
            PrintArray(a1);
            PrintArray(a2);

            MyArrayFunction(a1);
            Console.WriteLine(a1[0]);
            PrintArray(a1);

            int[] b1 = {9,8,7};
            int[] b2 = {5,5,5};
            Console.WriteLine(b1 == b2);

            b2[0] = b1[0];
            b2[1] = b1[1];
            b2[2] = b1[2];
            Console.WriteLine(b1 == b2);

            b2 = b1;
            Console.WriteLine(b1 == b2);
            b2[0] = -222;
            PrintArray(b1);
            PrintArray(b2);

            Console.WriteLine(b1 == b2);
        }

        static void MyArrayFunction(int[] arr) {
            arr[0] = 9999;
        }

        static void MyStringFunction(string x) {
            x = "NEW STRING!!!!!";
        }

        static void MyIntFunction(int x) {
            x = 999999;
        }


        static void PrintArray(int[] arr) {
            Console.WriteLine("--------");
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i]);
            }
        }

    }
}

