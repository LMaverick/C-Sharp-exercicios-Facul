using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaração do vetor A com 100 elementos
        double[] A = new double[100];

        // Loop para ler os 100 valores e armazená-los no vetor A
        for (int i = 0; i < 100; i++)
        {
            A[i] = double.Parse(Console.ReadLine());
        }

        // Loop para verificar os valores menores ou iguais a 10 e imprimir suas posições e valores
        for (int i = 0; i < 100; i++)
        {
            if (A[i] <= 10)
            {
                Console.WriteLine($"A[{i}] = {A[i]:F1}");
            }
        }
    }
}
