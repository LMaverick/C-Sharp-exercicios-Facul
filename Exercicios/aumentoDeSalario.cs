using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê o salário do funcionário
        double salario = double.Parse(Console.ReadLine());

        // Define as faixas de salário e seus respectivos percentuais de reajuste
        double[] faixas = { 400.00, 800.00, 1200.00, 2000.00, double.MaxValue };
        double[] percentuais = { 0.15, 0.12, 0.10, 0.07, 0.04 };

        // Encontra o percentual de reajuste correspondente ao salário
        double percentual = 0.0;
        for (int i = 0; i < faixas.Length; i++)
        {
            if (salario <= faixas[i])
            {
                percentual = percentuais[i];
                break;
            }
        }

        // Calcula o valor do reajuste e o novo salário
        double reajuste = salario * percentual;
        double novoSalario = salario + reajuste;

        // Imprime o novo salário, o valor do reajuste e o percentual de reajuste
        Console.WriteLine($"Novo salario: {novoSalario:F2}");
        Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
        Console.WriteLine($"Em percentual: {(percentual * 100):F0} %");
    }
}
