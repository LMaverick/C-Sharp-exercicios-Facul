using System;

class Program {
  public static void Main (string[] args) {
    double pi = 3.14159,R,area;

    R = double.Parse(Console.ReadLine());
    area = (4.0/3) * pi * Math.Pow(R,3);
    Console.WriteLine("VOLUME = " + area.ToString("F3"));
  }
}