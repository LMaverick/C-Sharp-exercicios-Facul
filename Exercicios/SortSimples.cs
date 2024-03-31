using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê os três valores inteiros
        string[] valores = Console.ReadLine().Split(' ');
        int a = int.Parse(valores[0]);
        int b = int.Parse(valores[1]);
        int c = int.Parse(valores[2]);

        // Ordena os valores em ordem crescente
        int temp;
        if (a > b)
        {
            temp = a;
            a = b;
            b = temp;
        }
        if (a > c)
        {
            temp = a;
            a = c;
            c = temp;
        }
        if (b > c)
        {
            temp = b;
            b = c;
            c = temp;
        }

        // Imprime os valores ordenados
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine();
        // Imprime os valores na sequência em que foram lidos
        Console.WriteLine(valores[0]);
        Console.WriteLine(valores[1]);
        Console.WriteLine(valores[2]);
    }
}
