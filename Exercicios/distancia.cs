using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê a distância em quilômetros
        int distancia = int.Parse(Console.ReadLine());

        // Calcula o tempo necessário para o carro Y alcançar o carro X
        // A cada 2 minutos, o carro Y consegue se afastar 1 quilômetro do carro X
        // Então, para alcançar uma distância de 'distancia' quilômetros,
        // o tempo necessário será 'distancia * 2' minutos
        int tempo = distancia * 2;

        // Imprime o resultado
        Console.WriteLine(tempo + " minutos");
    }
}
