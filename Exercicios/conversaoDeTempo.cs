using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê o tempo em segundos
        int tempoSegundos = int.Parse(Console.ReadLine());

        // Calcula o tempo em horas, minutos e segundos
        int horas = tempoSegundos / 3600;
        int minutos = (tempoSegundos % 3600) / 60;
        int segundos = tempoSegundos % 60;

        // Imprime o tempo no formato horas:minutos:segundos
        Console.WriteLine($"{horas}:{minutos}:{segundos}");
    }
}
