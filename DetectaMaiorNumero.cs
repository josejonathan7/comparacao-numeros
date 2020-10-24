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
           int atual, i=1, maior=0;
           
           do{
           	  Console.Clear();
           	  Console.WriteLine("Digite um valor, quando quiser sai digite 0, você esta no " + i + "° número:");
           	  atual = int.Parse(Console.ReadLine());
           	  if(atual > maior){
           	  	 maior = atual;
           	  }
           	i++;
           }while(atual != 0);
           Console.WriteLine("O maior valor digitado foi: " + maior);
           Console.ReadKey();
        }
    }
}