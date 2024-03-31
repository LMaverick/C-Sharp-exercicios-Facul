using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê o valor de N
        int N = int.Parse(Console.ReadLine());

        // Loop de 1 a 10000
        for (int i = 1; i <= 10000; i++)
        {
            // Verifica se o resto da divisão de i por N é igual a 2
            if (i % N == 2)
            {
                // Se for igual a 2, imprime o valor de i
                Console.WriteLine(i);
            }
        }
    }
}
