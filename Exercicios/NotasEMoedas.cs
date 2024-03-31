using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê o valor monetário
        double valor = double.Parse(Console.ReadLine());

        // Converte o valor para centavos (multiplica por 100)
        int centavos = (int)(valor * 100);

        // Vetor contendo os valores das notas e moedas em centavos
        int[] notasMoedasCentavos = { 10000, 5000, 2000, 1000, 500, 200, 100, 50, 25, 10, 5, 1 };

        // Vetor contendo as quantidades de cada nota/moeda
        int[] quantidadeNotasMoedas = new int[notasMoedasCentavos.Length];

        // Itera sobre as notas e moedas para calcular a quantidade de cada uma necessária
        for (int i = 0; i < notasMoedasCentavos.Length; i++)
        {
            quantidadeNotasMoedas[i] = centavos / notasMoedasCentavos[i];
            centavos %= notasMoedasCentavos[i];
        }

        // Imprime a quantidade mínima de notas e moedas necessárias
        Console.WriteLine("NOTAS:");
        Console.WriteLine($"{quantidadeNotasMoedas[0]} nota(s) de R$ 100.00");
        Console.WriteLine($"{quantidadeNotasMoedas[1]} nota(s) de R$ 50.00");
        Console.WriteLine($"{quantidadeNotasMoedas[2]} nota(s) de R$ 20.00");
        Console.WriteLine($"{quantidadeNotasMoedas[3]} nota(s) de R$ 10.00");
        Console.WriteLine($"{quantidadeNotasMoedas[4]} nota(s) de R$ 5.00");
        Console.WriteLine($"{quantidadeNotasMoedas[5]} nota(s) de R$ 2.00");
        Console.WriteLine("MOEDAS:");
        Console.WriteLine($"{quantidadeNotasMoedas[6]} moeda(s) de R$ 1.00");
        Console.WriteLine($"{quantidadeNotasMoedas[7]} moeda(s) de R$ 0.50");
        Console.WriteLine($"{quantidadeNotasMoedas[8]} moeda(s) de R$ 0.25");
        Console.WriteLine($"{quantidadeNotasMoedas[9]} moeda(s) de R$ 0.10");
        Console.WriteLine($"{quantidadeNotasMoedas[10]} moeda(s) de R$ 0.05");
        Console.WriteLine($"{quantidadeNotasMoedas[11]} moeda(s) de R$ 0.01");
    }
}
