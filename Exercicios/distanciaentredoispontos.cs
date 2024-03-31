using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê os valores de entrada
        string[] p1 = Console.ReadLine().Split(' ');
        string[] p2 = Console.ReadLine().Split(' ');

        // Converte os valores de string para double
        double x1 = double.Parse(p1[0]);
        double y1 = double.Parse(p1[1]);
        double x2 = double.Parse(p2[0]);
        double y2 = double.Parse(p2[1]);

        // Calcula a distância entre os pontos usando a fórmula fornecida
        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        // Imprime o resultado com 4 casas decimais
        Console.WriteLine(distancia.ToString("F4"));
    }
}
