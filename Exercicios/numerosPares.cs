using System;

class Program
{
    static void Main(string[] args)
    {
        // Loop de 1 a 100
        for (int i = 1; i <= 100; i++)
        {
            // Verifica se o número é par
            if (i % 2 == 0)
            {
                // Se for par, imprime o número
                Console.WriteLine(i);
            }
        }
    }
}
