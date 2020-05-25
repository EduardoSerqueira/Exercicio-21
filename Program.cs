﻿using System;

namespace Exercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] mat = new int[3, 3];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite uma sequência numérica: ");
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Diagonal principal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Negativos: " + count);
            Console.ReadKey();
        }
    }
}
