using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê o valor de X
        int X = int.Parse(Console.ReadLine());

        // Loop para encontrar os 6 números ímpares consecutivos a partir de X
        for (int i = X, count = 0; count < 6; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
                count++;
            }
        }
    }
}

