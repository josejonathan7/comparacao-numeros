using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
			int idade;
			string verdade = "maior de idade";
			string falso = "menor de idade";
			Console.WriteLine("Digite a idade para averiguação:");
			idade = int.Parse(Console.ReadLine());
			Console.WriteLine("A idade que voce digitou é " + ( idade >=18 ? verdade : falso));
			Console.ReadKey();
        }
    }
}