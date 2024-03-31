using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Define o estilo de formatação para números decimais
        CultureInfo culture = CultureInfo.InvariantCulture;

        // Lê o valor de entrada
        double valor = double.Parse(Console.ReadLine(), culture);

        // Verifica em qual intervalo o valor se encontra
        if (valor >= 0 && valor <= 25)
        {
            Console.WriteLine("Intervalo [0,25]");
        }
        else if (valor > 25 && valor <= 50)
        {
            Console.WriteLine("Intervalo (25,50]");
        }
        else if (valor > 50 && valor <= 75)
        {
            Console.WriteLine("Intervalo (50,75]");
        }
        else if (valor > 75 && valor <= 100)
        {
            Console.WriteLine("Intervalo (75,100]");
        }
        else
        {
            Console.WriteLine("Fora de intervalo");
        }
    }
}
