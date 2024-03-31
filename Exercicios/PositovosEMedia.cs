using System;

class Program
{
    static void Main(string[] args)
    {
        // Inicializa o contador de valores positivos
        int countPositivos = 0;
        // Inicializa a variável para acumular a soma dos valores positivos
        double somaPositivos = 0;

        // Loop para ler os 6 valores
        for (int i = 0; i < 6; i++)
        {
            double valor = double.Parse(Console.ReadLine());

            // Verifica se o valor é positivo
            if (valor > 0)
            {
                // Incrementa o contador de valores positivos
                countPositivos++;
                // Acumula o valor para calcular a média posteriormente
                somaPositivos += valor;
            }
        }

        // Imprime a quantidade de valores positivos
        Console.WriteLine($"{countPositivos} valores positivos");

        // Verifica se há valores positivos para calcular a média
        if (countPositivos > 0)
        {
            // Calcula e imprime a média dos valores positivos
            double mediaPositivos = somaPositivos / countPositivos;
            Console.WriteLine(mediaPositivos.ToString("F1"));
        }
    }
}
