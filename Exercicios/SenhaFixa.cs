  using System;

  class Program
  {
      static void Main(string[] args)
      {
          while (true)
          {
              string senha = Console.ReadLine();
              if (senha == "2002")
              {
                  Console.WriteLine("Acesso Permitido");
                  break;
              }
              else
              {
                  Console.WriteLine("Senha Invalida");
              }
          }
      }
  }
