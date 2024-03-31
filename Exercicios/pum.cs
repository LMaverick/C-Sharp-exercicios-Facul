using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê o valor de N
        int N = int.Parse(Console.ReadLine());

        // Inicializa a variável para o primeiro número da sequência
        int numero = 1;

        // Loop para gerar as N linhas de saída
        for (int i = 0; i < N; i++)
        {
            // Imprime os três números da sequência seguidos da string "PUM"
            Console.WriteLine($"{numero} {numero + 1} {numero + 2} PUM");

            // Atualiza o valor do primeiro número da próxima linha
            numero += 4;
        }
    }
}
