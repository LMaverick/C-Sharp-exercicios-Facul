using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // Leitura dos valores M e N
            string[] valores = Console.ReadLine().Split();
            int M = int.Parse(valores[0]);
            int N = int.Parse(valores[1]);

            // Verifica se algum dos valores é menor ou igual a zero para encerrar o programa
            if (M <= 0 || N <= 0)
            {
                break;
            }

            // Determina o menor e o maior valor entre M e N
            int menor = Math.Min(M, N);
            int maior = Math.Max(M, N);

            // Inicializa a soma dos valores
            int soma = 0;

            // Imprime a sequência e calcula a soma
            for (int i = menor; i <= maior; i++)
            {
                Console.Write(i + " ");
                soma += i;
            }

            // Imprime a soma
            Console.WriteLine("Sum=" + soma);
        }
    }
}
