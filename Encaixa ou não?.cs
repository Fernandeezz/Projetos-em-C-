//
Paulinho tem em suas mãos um novo problema. 
Agora a sua professora lhe pediu que construísse um programa para verificar, 
à partir de dois valores muito grandes A e B, se B corresponde 
aos últimos dígitos de A.
//

using System.IO;
using System.Linq;
using System;

class Program {
  static void Main(string[] args) {
    int qt = int.Parse(Console.ReadLine());
    string[] v = new string[2];
    for (int i = 0; i < qt; ++i) {
      v = Console.ReadLine().Split(" ");
      string a = v[0];
      string b = v[1];

      if (b.Length > a.Length)
        Console.WriteLine("nao encaixa");
      else if (a.EndsWith(b))
        Console.WriteLine("encaixa");
      else
        Console.WriteLine("nao encaixa");
    }
  }
}
