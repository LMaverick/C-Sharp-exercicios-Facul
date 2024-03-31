using System;

class Program {
  public static void Main (string[] args) {

    int NUMBER = int.Parse(Console.ReadLine());
    int HORAS = int.Parse(Console.ReadLine());
    double SALARIO_HORA = double.Parse(Console.ReadLine());
    double SALARIO = HORAS * SALARIO_HORA;

    Console.WriteLine("NUMBER = " + NUMBER);
    Console.WriteLine("SALARY = U$ " + SALARIO.ToString("F2"));

  }
}