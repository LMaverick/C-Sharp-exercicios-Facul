using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaração do vetor X com 10 elementos
        int[] X = new int[10];

        // Loop para ler os 10 valores e armazená-los no vetor X
        for (int i = 0; i < 10; i++)
        {
            X[i] = int.Parse(Console.ReadLine());
        }

        // Loop para substituir os valores nulos e negativos por 1
        for (int i = 0; i < 10; i++)
        {
            if (X[i] <= 0)
            {
                X[i] = 1;
            }
        }

        // Loop para imprimir o vetor X
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"X[{i}] = {X[i]}");
        }
    }
}
