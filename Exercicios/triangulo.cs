using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê os valores A, B e C
        string[] valores = Console.ReadLine().Split(' ');
        double A = double.Parse(valores[0]);
        double B = double.Parse(valores[1]);
        double C = double.Parse(valores[2]);

        // Verifica se os valores formam um triângulo
        if (A + B > C && A + C > B && B + C > A)
        {
            // Calcula o perímetro do triângulo
            double perimetro = A + B + C;
            Console.WriteLine($"Perimetro = {perimetro:F1}");
        }
        else
        {
            // Calcula a área do trapézio
            double area = ((A + B) * C) / 2.0;
            Console.WriteLine($"Area = {area:F1}");
        }
    }
}
