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
                            Console.Write("Enter X=");
                            int X = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Y=");
                            int Y = Convert.ToInt32(Console.ReadLine());

                            int[,] arr = LibraryArr.Random(Y, X);
                            for (int i = 0; i < arr.GetLength(0); i++)
                            {
                                for (int j = 0; j < arr.GetLength(1); j++)
                                {
                                    Console.Write(arr[i, j] + "\t");
                                }
                                Console.WriteLine();
                            }

                            Console.Write($"{Environment.NewLine}Maximum value = {LibraryArr.Task1(arr)}");
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine($"Task№2");
                            Console.Write("Enter X=");
                            int X = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Y=");
                            int Y = Convert.ToInt32(Console.ReadLine());
                            int[,] arr = LibraryArr.Random(Y, X);
                            for (int i = 0; i < arr.GetLength(0); i++)
                            {
                                for (int j = 0; j < arr.GetLength(1); j++)
                                {
                                    Console.Write(arr[i, j] + "\t");
                                }
                                Console.WriteLine();
                            }

                            Console.Write($"{Environment.NewLine}Maximum value = {LibraryArr.Task2(arr)}");
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine($"Task№3");
                            Console.Write("Enter X=");
                            int X = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Y=");
                            int Y = Convert.ToInt32(Console.ReadLine());
                            int[,] arr = LibraryArr.Random(Y, X);
                            for (int i = 0; i < arr.GetLength(0); i++)
                            {
                                for (int j = 0; j < arr.GetLength(1); j++)
                                {
                                    Console.Write(arr[i, j] + "\t");
                                }
                                Console.WriteLine();
                            }

                            (int column, int line) = LibraryArr.Task3(arr);

                            Console.WriteLine($"X= {line}{Environment.NewLine}Y= {column}");
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine($"Task№4");
                            Console.Write("Enter X=");
                            int X = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Y=");
                            int Y = Convert.ToInt32(Console.ReadLine());
                            int[,] arr = LibraryArr.Random(Y, X);
                            for (int i = 0; i < arr.GetLength(0); i++)
                            {
                                for (int j = 0; j < arr.GetLength(1); j++)
                                {
                                    Console.Write(arr[i, j] + "\t");
                                }
                                Console.WriteLine();
                            }

                            (int column, int line) = LibraryArr.Task4(arr);
                            Console.WriteLine($"X= {line}{Environment.NewLine}Y= {column}");
                            break;
                        }

                    case 5:
                        {
                            Console.WriteLine($"Task№4");
                            Console.Write("Enter X=");
                            int X = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Y=");
                            int Y = Convert.ToInt32(Console.ReadLine());
                            int[,] arr = LibraryArr.Random(Y, X);
                            for (int i = 0; i < arr.GetLength(0); i++)
                            {
                                for (int j = 0; j < arr.GetLength(1); j++)
                                {
                                    Console.Write(arr[i, j] + "\t");
                                }
                                Console.WriteLine();
                            }

                            Console.WriteLine(LibraryArr.Task5(arr));
                            break;
                        }

                }
            }

            while (userInput != 0);
        }
    }
}
