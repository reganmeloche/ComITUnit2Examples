using System;

namespace MyFirstProject
{
    public class Arrays
    {
        public static void Run() {

        }

        static void StudentGradesNoArray() {
            double student1Grade = 90;
            double student2Grade = 55;
            double student3Grade = 88.9;

            double averageGrade = (student1Grade + student2Grade + student3Grade) / 3;
            Console.WriteLine($"Average grade is {averageGrade}");
        }

        static void StudentGradesArray() {
            double[] studentGrades = { 55, 90, 88.9, 56, 45, 99, 88, 89};
            double sum = 0;
            for (int i = 0; i < studentGrades.Length; i++) {
                sum += studentGrades[i];
            }
            double averageGrade = sum / studentGrades.Length;
            Console.WriteLine($"The average grade is {averageGrade}");
        }
    }
}