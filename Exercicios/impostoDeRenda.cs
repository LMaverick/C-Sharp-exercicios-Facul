using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê o salário da entrada
        double salario = double.Parse(Console.ReadLine());

        double imposto = 0.0;

        // Calcula o imposto de renda de acordo com as faixas salariais
        if (salario <= 2000.00)
        {
            imposto = 0.0;
        }
        else if (salario <= 3000.00)
        {
            imposto = (salario - 2000.00) * 0.08;
        }
        else if (salario <= 4500.00)
        {
            imposto = 1000.00 * 0.08 + (salario - 3000.00) * 0.18;
        }
        else
        {
            imposto = 1000.00 * 0.08 + 1500.00 * 0.18 + (salario - 4500.00) * 0.28;
        }

        // Imprime o resultado, formatado como R$ com duas casas decimais
        if (imposto == 0.0)
        {
            Console.WriteLine("Isento");
        }
        else
        {
            Console.WriteLine($"R$ {imposto:F2}");
        }
    }
}
