using System;

class Program
{
    static void Main(string[] args)
    {
        int maior = int.MinValue;
        int posicao = 0;

        // Loop para ler os 100 valores
        for (int i = 1; i <= 100; i++)
        {
            // Lê o valor atual
            int valor = int.Parse(Console.ReadLine());

            // Verifica se o valor atual é maior que o maior valor encontrado até o momento
            if (valor > maior)
            {
                maior = valor;
                posicao = i;
            }
        }

        // Imprime o maior valor e sua posição
        Console.WriteLine(maior);
        Console.WriteLine(posicao);
    }
}
