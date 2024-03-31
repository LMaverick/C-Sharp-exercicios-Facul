using System;

class Program {
  public static void Main (string[] args) {

    string nome = Console.ReadLine();
    double salario = double.Parse(Console.ReadLine());
    double vendas = double.Parse(Console.ReadLine());

    double total = salario + (vendas * 0.15);
    Console.WriteLine("TOTAL = R$ " + total.ToString("F2"));
  }
}