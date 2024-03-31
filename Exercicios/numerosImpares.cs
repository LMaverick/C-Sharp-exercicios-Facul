using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê o valor de X
        int X = int.Parse(Console.ReadLine());

        // Loop para encontrar os ímpares e imprimir
        for (int i = 1; i <= X; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}
