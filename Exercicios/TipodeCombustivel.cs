using System;

class Program
{
    static void Main(string[] args)
    {
        // Inicialização das variáveis para contar o número de clientes para cada tipo de combustível
        int alcool = 0, gasolina = 0, diesel = 0;

        // Loop para ler os códigos dos combustíveis até que seja informado o código 4
        int codigo;
        do
        {
            codigo = int.Parse(Console.ReadLine());

            // Verifica se o código é válido e incrementa o contador correspondente
            switch (codigo)
            {
                case 1:
                    alcool++;
                    break;
                case 2:
                    gasolina++;
                    break;
                case 3:
                    diesel++;
                    break;
                case 4:
                    break;
            }

        } while (codigo != 4);

        // Impressão dos resultados
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + alcool);
        Console.WriteLine("Gasolina: " + gasolina);
        Console.WriteLine("Diesel: " + diesel);
    }
}
