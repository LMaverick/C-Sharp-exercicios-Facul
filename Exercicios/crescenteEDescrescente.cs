using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // Leitura dos valores X e Y
            string[] valores = Console.ReadLine().Split();
            int X = int.Parse(valores[0]);
            int Y = int.Parse(valores[1]);

            // Verifica se os valores são iguais, o que indica o fim da leitura
            if (X == Y)
            {
                break;
            }

            // Verifica se os valores estão em ordem crescente
            if (X < Y)
            {
                Console.WriteLine("Crescente");
            }
            // Verifica se os valores estão em ordem decrescente
            else
            {
                Console.WriteLine("Decrescente");
            }
        }
    }
}
