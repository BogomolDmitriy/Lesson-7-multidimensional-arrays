using System;

namespace LibraryLesson7
{
    public class LibraryArr
    {
        public static int Task1(int Y, int X)
        {
            int[,] arr = new int[Y, X];
            Random random = new Random();
            for (int i=0; i < arr.GetLength(0); i++)
            {
                for (int j=0; j < arr.GetLength(1); j++)
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
                    if (arr[i,j]<min)
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
            int line=0;
            int column=0;
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
                        column = i;
                        line = j;
                    }
                }
            }

            return column, line;
        }

    }
}
