using System;

class Program
{
    static void Main(string[] args)
    {
        // Leitura dos valores de entrada
        int X = int.Parse(Console.ReadLine());
        int Y = int.Parse(Console.ReadLine());

        // Garantir que X seja o menor valor e Y seja o maior valor
        if (X > Y)
        {
            int temp = X;
            X = Y;
            Y = temp;
        }

        // Iterar de X+1 até Y-1 e imprimir os valores cujo resto da divisão por 5 é igual a 2 ou igual a 3
        for (int i = X + 1; i < Y; i++)
        {
            if (i % 5 == 2 || i % 5 == 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
