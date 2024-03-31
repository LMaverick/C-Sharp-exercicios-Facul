using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê o valor inteiro
        int valor = int.Parse(Console.ReadLine());

        // Vetor contendo os valores das cédulas
        int[] cedulas = { 100, 50, 20, 10, 5, 2, 1 };

        // Imprime o valor lido
        Console.WriteLine(valor);

        // Itera sobre as cédulas para calcular a quantidade de cada uma necessária
        foreach (int cedula in cedulas)
        {
            int quantidadeCedulas = valor / cedula; // Calcula a quantidade de cédulas
            Console.WriteLine(quantidadeCedulas + " nota(s) de R$ " + cedula + ",00");
            valor %= cedula; // Atualiza o valor para considerar as cédulas já contadas
        }
    }
}
