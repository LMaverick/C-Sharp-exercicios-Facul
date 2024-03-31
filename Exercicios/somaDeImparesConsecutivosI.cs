using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê os valores de X e Y
        int X = int.Parse(Console.ReadLine());
        int Y = int.Parse(Console.ReadLine());

        // Garante que X é sempre menor que Y
        if (X > Y)
        {
            int temp = X;
            X = Y;
            Y = temp;
        }

        int sum = 0;

        // Loop para encontrar os números ímpares entre X e Y e calcular a soma
        for (int i = X + 1; i < Y; i++)
        {
            if (i % 2 != 0)
            {
                sum += i;
            }
        }

        // Imprime a soma dos números ímpares
        Console.WriteLine(sum);
    }
}
