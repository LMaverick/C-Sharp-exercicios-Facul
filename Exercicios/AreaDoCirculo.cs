using System;

class Program {
  public static void Main (string[] args) {
    double n = 3.14159,raio,area;

    raio = double.Parse(Console.ReadLine());
    area = n * Math.Pow(raio,2);
    Console.WriteLine("A=" + area.ToString("F4"));
  }
}