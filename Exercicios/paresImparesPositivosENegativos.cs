using System;

class Program
{
    static void Main(string[] args)
    {
        // Inicializa os contadores
        int countPares = 0, countImpares = 0, countPositivos = 0, countNegativos = 0;

        // Loop para ler os 5 valores
        for (int i = 0; i < 5; i++)
        {
            int valor = int.Parse(Console.ReadLine());

            // Verifica se o valor é par
            if (valor % 2 == 0)
            {
                countPares++;
            }
            else
            {
                countImpares++;
            }

            // Verifica se o valor é positivo ou negativo
            if (valor > 0)
            {
                countPositivos++;
            }
            else if (valor < 0)
            {
                countNegativos++;
            }
        }

        // Imprime os resultados
        Console.WriteLine($"{countPares} valor(es) par(es)");
        Console.WriteLine($"{countImpares} valor(es) impar(es)");
        Console.WriteLine($"{countPositivos} valor(es) positivo(s)");
        Console.WriteLine($"{countNegativos} valor(es) negativo(s)");
    }
}
