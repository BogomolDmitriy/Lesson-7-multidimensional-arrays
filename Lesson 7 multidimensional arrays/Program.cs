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
                            bool result;
                            int X;
                            int Y;
                            Console.WriteLine($"Task№1");
                            do
                            {
                                Console.Write("Enter X =");
                                result = int.TryParse(Console.ReadLine(), out X);
                            } while (!result);

                            do
                            {
                                Console.Write("Enter Y =");
                                result = int.TryParse(Console.ReadLine(), out Y);
                            } while (!result);

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
                            bool result;
                            int X;
                            int Y;
                            Console.WriteLine($"Task№2");
                            do
                            {
                                Console.Write("Enter X =");
                                result = int.TryParse(Console.ReadLine(), out X);
                            } while (!result);

                            do
                            {
                                Console.Write("Enter Y =");
                                result = int.TryParse(Console.ReadLine(), out Y);
                            } while (!result);

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
                            bool result;
                            int X;
                            int Y;
                            Console.WriteLine($"Task№3");
                            do
                            {
                                Console.Write("Enter X =");
                                result = int.TryParse(Console.ReadLine(), out X);
                            } while (!result);

                            do
                            {
                                Console.Write("Enter Y =");
                                result = int.TryParse(Console.ReadLine(), out Y);
                            } while (!result);

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
                            bool result;
                            int X;
                            int Y;
                            Console.WriteLine($"Task№4");
                            do
                            {
                                Console.Write("Enter X =");
                                result = int.TryParse(Console.ReadLine(), out X);
                            } while (!result);

                            do
                            {
                                Console.Write("Enter Y =");
                                result = int.TryParse(Console.ReadLine(), out Y);
                            } while (!result);

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
                            bool result;
                            int X;
                            int Y;
                            Console.WriteLine($"Task№5");
                            do
                            {
                                Console.Write("Enter X =");
                                result = int.TryParse(Console.ReadLine(), out X);
                            } while (!result);

                            do
                            {
                                Console.Write("Enter Y =");
                                result = int.TryParse(Console.ReadLine(), out Y);
                            } while (!result);

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
