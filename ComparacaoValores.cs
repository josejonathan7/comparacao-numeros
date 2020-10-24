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
           int num, par=0, impar=0, positivo=0, negativo=0, i=1;
           
           do{
           	   Console.Clear();
           	   Console.WriteLine("Digite um número para continuar no programa, e digite 0 para sair, você esta no " + i + "° número:");
           	   num = int.Parse(Console.ReadLine());
           	   
           	   if(num == 0){
           	   	 break;
           	   } else{
           	   	 if(num % 2 != 0){
           	   	   impar++;
           	   	 } else{
           	   	 	if(num % 2 == 0){
           	   	 		par++;
           	   	 	}
           	   	 }
           	   }
           	   
           	   if(num > 0){
           	   	  positivo++;
           	   } else{
           	   	  if(num<0){
           	   	 negativo++;
           	   	  } else{
           	   	  	 if(num == 0){
           	   	  	 	break;
           	   	  	 }
           	   	  }
           	   }
           	i++;
           }while(num != 0);
            Console.WriteLine("A quantidade de numeros pares digitados foi: " + par + " e a de ímpares foi: " + impar);
    		Console.WriteLine("A quantidade de numeros positivos digitados foi: " + positivo + " e a de negativos foi: " + negativo);
    		Console.ReadKey();
        }
    }
}