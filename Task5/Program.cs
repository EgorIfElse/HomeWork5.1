﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ведите целочисленное значение N");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = ((i + j) % 2 == 0) ? 1 : 0;
                Console.Write(array[i, j]);
            }
            Console.WriteLine();
        }
}