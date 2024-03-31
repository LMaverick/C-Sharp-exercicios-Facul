using System;

class Program
{
    static void Main(string[] args)
    {
        // Leitura das tomadas de cada régua
        string[] entrada = Console.ReadLine().Split(' ');
        int T1 = int.Parse(entrada[0]);
        int T2 = int.Parse(entrada[1]);
        int T3 = int.Parse(entrada[2]);
        int T4 = int.Parse(entrada[3]);

        // Calculando o número máximo de aparelhos que podem ser conectados
        int totalTomadas = T1 + T2 + T3 + T4 - 3; // Subtraindo o número de réguas
        Console.WriteLine(totalTomadas);
    }
}
