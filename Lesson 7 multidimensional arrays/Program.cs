using LibraryLesson7;
using System;

namespace Lesson_7_multidimensional_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            do
            {
                userInput = Convert.ToInt32(Console.ReadLine());
                switch(userInput)
                {
                    case 1:
                        {


                            Console.WriteLine($"Task№1");
                            Console.Write("Enter Y=");
                            int Y = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter X=");
                            int X = Convert.ToInt32(Console.ReadLine());
                            Console.Write($"{Environment.NewLine}Minimum value = {LibraryArr.Task1(Y, X)}");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"Task№2");
                            Console.Write("Enter Y=");
                            int Y = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter X=");
                            int X = Convert.ToInt32(Console.ReadLine());
                            Console.Write($"{Environment.NewLine}Maximum value = {LibraryArr.Task2(Y, X)}");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Task№3");
                            Console.Write("Enter Y=");
                            int Y = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter X=");
                            int X = Convert.ToInt32(Console.ReadLine());

                            (int column, int line) = LibraryArr.Task3(Y, X);
                            break;
                        }
                }
            }

            while (userInput != 0);
        }
    }
}
