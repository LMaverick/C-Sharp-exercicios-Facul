using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Lê o número de casos de teste
        int N = int.Parse(Console.ReadLine());

        // Loop para cada caso de teste
        for (int i = 0; i < N; i++)
        {
            // Lê os três valores
            string[] valores = Console.ReadLine().Split(' ');
            double valor1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double valor2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double valor3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            // Calcula a média ponderada
            double mediaPonderada = (valor1 * 2.0 + valor2 * 3.0 + valor3 * 5.0) / 10.0;

            // Imprime o resultado da média ponderada
            Console.WriteLine(mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
