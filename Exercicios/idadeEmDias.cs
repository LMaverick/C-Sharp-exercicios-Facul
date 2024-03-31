using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê a idade em dias
        int idadeDias = int.Parse(Console.ReadLine());

        // Calcula a idade em anos, meses e dias
        int anos = idadeDias / 365;
        int meses = (idadeDias % 365) / 30;
        int dias = (idadeDias % 365) % 30;

        // Imprime a idade no formato anos meses dias
        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dias} dia(s)");
    }
}
