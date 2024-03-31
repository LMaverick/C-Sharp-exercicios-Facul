using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê a quantidade de casos de teste
        int N = int.Parse(Console.ReadLine());

        // Loop para processar cada caso de teste
        for (int i = 0; i < N; i++)
        {
            // Lê o valor do caso de teste
            int X = int.Parse(Console.ReadLine());

            // Verifica se o valor é zero
            if (X == 0)
            {
                Console.WriteLine("NULL");
            }
            else
            {
                // Verifica se o valor é par ou ímpar
                string parOuImpar = (X % 2 == 0) ? "EVEN" : "ODD";

                // Verifica se o valor é positivo ou negativo
                string posOuNeg = (X > 0) ? "POSITIVE" : "NEGATIVE";

                // Imprime a mensagem correspondente
                Console.WriteLine(parOuImpar + " " + posOuNeg);
            }
        }
    }
}
