using System;

namespace LibraryLesson7
{
    public class LibraryArr
    {
        public static int Task1(int Y, int X)
        {
            int[,] arr = new int[Y, X];
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(1000);
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int min = arr[0, 1];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                }
            }

            return min;
        }

        public static int Task2(int Y, int X)
        {
            int[,] arr = new int[Y, X];
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(1000);
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int max = arr[0, 1];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }

            return max;
        }

        public static (int column, int line) Task3(int Y, int X)
        {
            int[,] arr = new int[Y, X];
            Random random = new Random();
            int line = 0;
            int column = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(1000);
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int min = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        column = i;
                        line = j;
                    }
                }
            }

            return (column, line);
        }

        public static (int column, int line) Task4(int Y, int X)
        {
            int[,] arr = new int[Y, X];
            Random random = new Random();
            int line = 0;
            int column = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(1000);
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        column = i;
                        line = j;
                    }
                }
            }

            return (column, line);

        }
        public static int Task5(int Y, int X)
        {
            int[,] arr = new int[Y, X];
            Random random = new Random();
            int more = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(1000);
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int counter = 0;
                    //1
                    if (i - 1 >= 0 && j - 1 >= 0)
                    {
                        if (arr[i, j] > arr[i - 1, j - 1])
                        {
                            counter++;
                        }    
                    }

                    else
                    {
                        counter++;
                    }

                    //2
                    if (i - 1 >= 0)
                    {
                        if (arr[i, j] > arr[i - 1, j])
                        {
                            counter++;
                        }
                    }

                    else
                    {
                        counter++;
                    }

                    //3
                    if (i - 1 >= 0 && j + 1 <= arr.GetLength(1)-1)
                    {
                        if (arr[i, j] > arr[i - 1, j + 1])
                        {
                            counter++;
                        }
                    }

                    else
                    {
                        counter++;
                    }

                    //4
                    if (j - 1 >= 0)
                    {
                        if (arr[i, j] > arr[i, j - 1])
                        {
                            counter++;
                        }
                    }

                    else
                    {
                        counter++;
                    }

                    //5
                    if (j + 1 <= arr.GetLength(1)-1)
                    {
                        if (arr[i, j] > arr[i, j + 1])
                        {
                            counter++;
                        }
                    }

                    else
                    {
                        counter++;
                    }

                    //6
                    if (i + 1 <= arr.GetLength(0)-1 && j - 1 >= 0)
                    {
                        if (arr[i, j] > arr[i + 1, j - 1])
                        {
                            counter++;
                        }
                    }

                    else
                    {
                        counter++;
                    }

                    //7
                    if (i + 1 <= arr.GetLength(0)-1)
                    {
                        if (arr[i, j] > arr[i + 1, j])
                        {
                            counter++;
                        }
                    }

                    else
                    {
                        counter++;
                    }

                    //8
                    if (i + 1 <= arr.GetLength(0)-1 && j + 1 <= arr.GetLength(1)-1)
                    {
                        if (arr[i, j] > arr[i + 1, j + 1])
                        {
                            counter = counter + 1;
                        }
                    }

                    else
                    {
                        counter++;
                    }

                    if (counter == 8)
                    {
                        more++;
                    }
                }
            }

            return (more);
        }
    }
}
