using System;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        // Imprimindo os "Ho" separados por espaço
        for (int i = 0; i < N - 1; i++)
        {
            Console.Write("Ho ");
        }

        // Último "Ho" com exclamação
        Console.WriteLine("Ho!");
    }
}
