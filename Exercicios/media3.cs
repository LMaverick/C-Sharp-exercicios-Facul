using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê as notas do aluno
        string[] notas = Console.ReadLine().Split(' ');
        double N1 = double.Parse(notas[0]);
        double N2 = double.Parse(notas[1]);
        double N3 = double.Parse(notas[2]);
        double N4 = double.Parse(notas[3]);

        // Calcula a média ponderada arredondando para baixo
        double media = Math.Floor((N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10.0 * 10) / 10.0;

        // Imprime a média
        Console.WriteLine("Media: " + media.ToString("F1"));

        // Verifica a situação do aluno
        if (media >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5.0)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine("Aluno em exame.");
            // Lê a nota do exame
            double notaExame = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota do exame: " + notaExame.ToString("F1"));
            // Recalcula a média final
            double mediaFinal = Math.Floor((media + notaExame) / 2.0 * 10) / 10.0;
            // Verifica se o aluno foi aprovado ou reprovado após o exame
            if (mediaFinal >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }
            // Imprime a média final
            Console.WriteLine("Media final: " + mediaFinal.ToString("F1"));
        }
    }
}
