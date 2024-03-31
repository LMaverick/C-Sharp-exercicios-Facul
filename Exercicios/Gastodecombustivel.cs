using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê o tempo gasto na viagem em horas e a velocidade média em km/h
        int tempo = int.Parse(Console.ReadLine());
        int velocidadeMedia = int.Parse(Console.ReadLine());

        // Calcula a distância percorrida em km (velocidade média * tempo)
        double distanciaPercorrida = tempo * velocidadeMedia;

        // Calcula a quantidade de litros necessária (distância percorrida / consumo do carro)
        double litrosNecessarios = distanciaPercorrida / 12.0;

        // Imprime o resultado com 3 casas decimais
        Console.WriteLine(litrosNecessarios.ToString("F3"));
    }
}
