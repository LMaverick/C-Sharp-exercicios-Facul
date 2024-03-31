using System;

class Program
{
    static void Main(string[] args)
    {
        int valoresPositivos = 0;

        // Loop para ler os seis valores
        for (int i = 0; i < 6; i++)
        {
            // Lê o valor da entrada
            string input = Console.ReadLine();

            // Tenta converter o valor para inteiro
            if (int.TryParse(input, out int valor))
            {
                // Verifica se o valor é positivo
                if (valor > 0)
                {
                    // Incrementa a contagem de valores positivos
                    valoresPositivos++;
                }
            }

        }

        // Imprime a quantidade de valores positivos
        Console.WriteLine(valoresPositivos + " valores positivos");
    }
}
