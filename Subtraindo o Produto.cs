//
Dado um número inteiro ( n ) , retorne a diferença entre o produto de seus dígitos e a soma de seus dígitos.
//

using System;

class DIO {
        
static void Main(string[] args){
        int n = int.Parse(Console.ReadLine());
        int p = 1, s = 0;
        while (n > 0){
             int l = n % 10;
             n = (n -l)/10;
             p = p * l;
             s = s + l;
           }
           Console.WriteLine(p-s);
        }
    }
