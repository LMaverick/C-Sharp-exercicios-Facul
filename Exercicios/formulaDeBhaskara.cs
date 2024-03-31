using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê os valores de entrada
        string[] valores = Console.ReadLine().Split(' ');
        double A = double.Parse(valores[0]);
        double B = double.Parse(valores[1]);
        double C = double.Parse(valores[2]);

        // Calcula o delta da equação de Bhaskara
        double delta = Math.Pow(B, 2) - 4 * A * C;

        // Verifica se é possível calcular as raízes
        if (delta < 0 || A == 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            // Calcula as raízes
            double x1 = (-B + Math.Sqrt(delta)) / (2 * A);
            double x2 = (-B - Math.Sqrt(delta)) / (2 * A);

            // Imprime as raízes com 5 dígitos após o ponto
            Console.WriteLine($"R1 = {x1.ToString("F5")}");
            Console.WriteLine($"R2 = {x2.ToString("F5")}");
        }
    }
}
