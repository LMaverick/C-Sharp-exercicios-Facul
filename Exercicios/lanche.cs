using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê o código do item e a quantidade
        string[] entrada = Console.ReadLine().Split(' ');
        int codigo = int.Parse(entrada[0]);
        int quantidade = int.Parse(entrada[1]);

        // Define os preços dos itens de acordo com o código
        double preco = 0;
        switch (codigo)
        {
            case 1:
                preco = 4.00;
                break;
            case 2:
                preco = 4.50;
                break;
            case 3:
                preco = 5.00;
                break;
            case 4:
                preco = 2.00;
                break;
            case 5:
                preco = 1.50;
                break;
            default:
                break;
        }

        // Calcula o valor total da conta
        double total = preco * quantidade;

        // Imprime o valor total formatado
        Console.WriteLine("Total: R$ " + total.ToString("F2"));
    }
}
