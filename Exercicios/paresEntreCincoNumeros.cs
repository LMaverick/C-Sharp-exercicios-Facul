using System;

class Program
{
    static void Main(string[] args)
    {
        // Inicializa o contador de valores pares
        int countPares = 0;

        // Loop para ler os 5 valores
        for (int i = 0; i < 5; i++)
        {
            int valor = int.Parse(Console.ReadLine());

            // Verifica se o valor é par
            if (valor % 2 == 0)
            {
                // Incrementa o contador de valores pares
                countPares++;
            }
        }

        // Imprime a quantidade de valores pares lidos
        Console.WriteLine($"{countPares} valores pares");
    }
}
