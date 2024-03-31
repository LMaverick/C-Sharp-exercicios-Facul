using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê os valores de entrada em uma única linha e armazena em um array de strings
        string[] valores = Console.ReadLine().Split(' ');

        // Converte cada elemento do array para double
        double A = double.Parse(valores[0]);
        double B = double.Parse(valores[1]);
        double C = double.Parse(valores[2]);

        // Calcula a área do triângulo retângulo (base A, altura C)
        double areaTriangulo = (A * C) / 2.0;

        // Calcula a área do círculo (raio C)
        double areaCirculo = 3.14159 * C * C;

        // Calcula a área do trapézio (bases A e B, altura C)
        double areaTrapezio = ((A + B) * C) / 2.0;

        // Calcula a área do quadrado (lado B)
        double areaQuadrado = B * B;

        // Calcula a área do retângulo (lados A e B)
        double areaRetangulo = A * B;

        // Imprime os resultados formatados
        Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3"));
        Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3"));
        Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3"));
        Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3"));
        Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3"));
    }
}
