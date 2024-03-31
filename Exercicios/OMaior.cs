using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê os valores de entrada
        string[] valores = Console.ReadLine().Split(' ');
        int a = int.Parse(valores[0]);
        int b = int.Parse(valores[1]);
        int c = int.Parse(valores[2]);

        // Calcula o maior entre a e b usando a fórmula fornecida
        int maiorAB = (a + b + Math.Abs(a - b)) / 2;

        // Calcula o maior entre o resultado anterior (maiorAB) e c
        int maiorABC = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

        // Imprime o resultado
        Console.WriteLine(maiorABC.ToString("F0") + " eh o maior");
    }
}
