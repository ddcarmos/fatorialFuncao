using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Me informe um numero: ");
    int n = int.Parse(Console.ReadLine());
    
    int f = fatorial(n);
    Console.WriteLine(f);
    
  }
  public static int fatorial(int numero)
   {
    int f = 1;
    for (int i=1;i<=numero;i++)
    {
      f= f * i;
    }
    return f;
   }
}

