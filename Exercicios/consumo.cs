using System;

class Program
{
    static void Main(string[] args)
    {
      int x = int.Parse(Console.ReadLine());
      double y = double.Parse(Console.ReadLine());


      double km = x / y;

      Console.WriteLine(km.ToString("F3") + " km/l");

      }
  }