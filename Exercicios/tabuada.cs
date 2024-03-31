using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê o valor de N
        int N = int.Parse(Console.ReadLine());

        // Loop de 1 a 10 para imprimir a tabuada
        for (int i = 1; i <= 10; i++)
        {
            // Calcula o resultado da multiplicação
            int resultado = i * N;

            // Imprime a tabuada
            Console.WriteLine($"{i} x {N} = {resultado}");
        }
    }
}
