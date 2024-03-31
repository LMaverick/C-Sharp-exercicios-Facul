using System;

class Program
{
    static void Main(string[] args)
    {
        // Leitura dos dados de entrada
        string[] inicioDia = Console.ReadLine().Split();
        int diaInicio = int.Parse(inicioDia[1]);

        string[] inicioHorario = Console.ReadLine().Split(':');
        int horaInicio = int.Parse(inicioHorario[0]);
        int minInicio = int.Parse(inicioHorario[1]);
        int segInicio = int.Parse(inicioHorario[2]);

        string[] fimDia = Console.ReadLine().Split();
        int diaFim = int.Parse(fimDia[1]);

        string[] fimHorario = Console.ReadLine().Split(':');
        int horaFim = int.Parse(fimHorario[0]);
        int minFim = int.Parse(fimHorario[1]);
        int segFim = int.Parse(fimHorario[2]);

        // Cálculo da diferença de tempo
        int totalInicioSegundos = (diaInicio * 24 * 60 * 60) + (horaInicio * 60 * 60) + (minInicio * 60) + segInicio;
        int totalFimSegundos = (diaFim * 24 * 60 * 60) + (horaFim * 60 * 60) + (minFim * 60) + segFim;
        int diferencaSegundos = totalFimSegundos - totalInicioSegundos;

        // Conversão para dias, horas, minutos e segundos
        int dias = diferencaSegundos / (24 * 60 * 60);
        diferencaSegundos %= (24 * 60 * 60);
        int horas = diferencaSegundos / (60 * 60);
        diferencaSegundos %= (60 * 60);
        int minutos = diferencaSegundos / 60;
        int segundos = diferencaSegundos % 60;

        // Impressão da duração do evento
        Console.WriteLine($"{dias} dia(s)");
        Console.WriteLine($"{horas} hora(s)");
        Console.WriteLine($"{minutos} minuto(s)");
        Console.WriteLine($"{segundos} segundo(s)");
    }
}
