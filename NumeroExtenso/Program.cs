using System;
using System.Runtime.InteropServices;
using System.Threading;


namespace MeuProjeto;

class Program
{

    static void Main(string[] args)
    {
        Console.Clear();

        // int [] array = {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
        int input;
        while(true)
        {
            try{
                Console.Write("Digite um número entre 0 e 20: ");
                input=int.Parse(Console.ReadLine());

            
        
                if(input >= 0 && input <= 20){
                    Console.WriteLine($"Você digitou o número {NumExtenso(input)}");
                    break;
                }else Console.WriteLine("Entrada incorreta!");
            
            }catch(FormatException){
                Console.WriteLine("Entrada incorreta!");
            }
            
        
        }

        
     
    }
    
    public static string NumExtenso(int input)
{
    switch(input)
    {
        case 0: return "zero";
        case 1: return "um";
        case 2: return "dois";
        case 3: return "três";
        case 4: return "quatro";
        case 5: return "cinco";
        case 6: return "seis";
        case 7: return "sete";
        case 8: return "oito";
        case 9: return "nove";
        case 10: return "dez";
        case 11: return "onze";
        case 12: return "doze";
        case 13: return "treze";
        case 14: return "quatorze";
        case 15: return "quinze";
        case 16: return "dezesseis";
        case 17: return "dezessete";
        case 18: return "dezoito";
        case 19: return "dezenove";
        case 20: return "vinte";
        default: return "Número fora do intervalo de 0 a 20.";
    }
}
  
    
}






