using System;

namespace case_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your grade: ");
            string userGrade = Console.ReadLine();

            switch (userGrade)
            {
                case "A+":
                case "A":
                    Console.WriteLine("Distinction");
                    break;
                case "B":
                    Console.WriteLine("B Grade");
                    break;
                case "C":
                    Console.WriteLine("C Grade");
                    break;
                default:
                    Console.WriteLine("Fail");
                    break;
            }
        }
    }
}
