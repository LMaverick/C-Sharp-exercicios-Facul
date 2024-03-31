using System;

class Program
{
    static void Main(string[] args)
    {
        // Lendo o tamanho do vetor
        int N = int.Parse(Console.ReadLine());

        // Declarando o vetor X de tamanho N
        int[] X = new int[N];

        // Lendo os elementos do vetor
        string[] valores = Console.ReadLine().Split(' ');
        for (int i = 0; i < N; i++)
        {
            X[i] = int.Parse(valores[i]);
        }

        // Encontrando o menor valor e sua posição
        int menorValor = X[0];
        int posicao = 0;
        for (int i = 1; i < N; i++)
        {
            if (X[i] < menorValor)
            {
                menorValor = X[i];
                posicao = i;
            }
        }

        // Imprimindo o menor valor e sua posição
        Console.WriteLine($"Menor valor: {menorValor}");
        Console.WriteLine($"Posicao: {posicao}");
    }
}
