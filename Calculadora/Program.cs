﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args){
            Console.Clear();
        
        Console.Write("Digite um número: ");
        float num1 = float.Parse(Console.ReadLine());
        
        Console.Write("Digite Outro número: ");
        float num2 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Selecione Oque deseja fazer:\n[1]Somar \n[2]Subtrair \n[3]Dividir \n[4]Multiplicar");
        int res = int.Parse(Console.ReadLine());

        
        

        switch (res){
            case 1: Console.WriteLine($"A soma é igual a: {Somar(num1,num2)}"); break;
            case 2: Console.WriteLine($"A subtração é igual a: {Subtrair(num1,num2)}"); break;
            case 3: Console.WriteLine($"A divisão é igual a: {Dividir(num1,num2)}"); break;
            case 4: Console.WriteLine($"A multiplicação é igual a: {(num1,num2)}"); break;

            }
        }

            static float Somar(float af, float bf){
                return af + bf;
            }
            static float Subtrair(float af, float bf){
                return af - bf;
            }
            static float Multiplicar(float af, float bf){
                return af * bf;
            }
            static float Dividir(float af, float bf){
                return af / bf;
            }
            }
        }
    


//         Console.Clear();
        
//         Console.Write("Digite um número: ");
//         float num1 = float.Parse(Console.ReadLine());
        
//         Console.Write("Digite Outro número: ");
//         float num2 = float.Parse(Console.ReadLine());
        
//         Console.WriteLine("Selecione Oque deseja fazer:\n[1]Somar \n[2]Subtrair \n[3]Dividir \n[4]Multiplicar");
//         int res = int.Parse(Console.ReadLine());

//         switch (res){
//             case 1: Console.WriteLine($"A soma é igual a: {Somar(num1,num2)}"); break;
//             case 2: Console.WriteLine($"A subtração é igual a: {Subtrair(num1,num2)}"); break;
//             case 3: Console.WriteLine($"A divisão é igual a: {Dividir(num1,num2)}"); break;
//             case 4: Console.WriteLine($"A multiplicação é igual a: {(num1,num2)}"); break;

//         }
//     }

//     static float Somar(float af, float bf){
//         return af + bf;
//     }
//     static float Subtrair(float af, float bf){
//         return af - bf;
//     }
//     static float Multiplicar(float af, float bf){
//         return af * bf;
//     }
//     static float Dividir(float af, float bf){
//         return af / bf;
//     }
// }




// static void Main(string[] args)
        // {
        //     Menu();
        // }

        // static void Menu()
        // {
        //     Console.Clear();

        //     Console.WriteLine("O que deseja fazer?");
        //     Console.WriteLine("1 - Soma");
        //     Console.WriteLine("2 - Subtração");
        //     Console.WriteLine("3 - Divisão");
        //     Console.WriteLine("4 - Multiplicação");
        //     Console.WriteLine("5 - Sair");

        //     Console.WriteLine("----------");
        //     Console.WriteLine("Selecione uma opção: ");

        //     short res = short.Parse(Console.ReadLine());

        //     switch (res)
        //     {
        //         case 1: Soma(); break;
        //         case 2: Subtracao(); break;
        //         case 3: Divisao(); break;
        //         case 4: Multiplicacao(); break;
        //         case 5: System.Environment.Exit(0); break;
        //         default: Menu(); break;
        //     }
        // }

        // static void Soma()
        // {
        //     Console.Clear();

        //     Console.WriteLine("Primeiro valor: ");
        //     float v1 = float.Parse(Console.ReadLine());

        //     Console.WriteLine("Segundo valor:");
        //     float v2 = float.Parse(Console.ReadLine());

        //     Console.WriteLine("");

        //     float resultado = v1 + v2;
        //     // Console.WriteLine("O resultado da soma é " + resultado);
        //     Console.WriteLine($"O resultado da soma é {resultado}");
        //     // Console.WriteLine($"O resultado da soma é {v1 + v2}");
        //     // Console.WriteLine("O resultado da soma é " + (v1 + v2));
        //     Console.ReadKey();
        //     Menu();
        // }

        // static void Subtracao()
        // {
        //     Console.Clear();

        //     Console.WriteLine("Primeiro valor:");
        //     float v1 = float.Parse(Console.ReadLine());

        //     Console.WriteLine("Segundo valor:");
        //     float v2 = float.Parse(Console.ReadLine());

        //     Console.WriteLine("");

        //     float resultado = v1 - v2;
        //     Console.WriteLine($"O resultado da subtração é {resultado}");
        //     Console.ReadKey();
        //     Menu();
        // }

        // static void Divisao()
        // {
        //     Console.Clear();

        //     Console.WriteLine("Primeiro valor:");
        //     float v1 = float.Parse(Console.ReadLine());

        //     Console.WriteLine("Segundo valor");
        //     float v2 = float.Parse(Console.ReadLine());
            
        //     while (v2==0){
                
        //             Console.Write("Erro! Não é possível dividir por zero. Digite o segundo valor novamente: ");
        //             v2 = float.Parse(Console.ReadLine());
        //             if (v2 != 0){
        //                 break;
        //             }
        //     }

        //     Console.WriteLine("");


        //     float resultado = v1 / v2;
        //     Console.WriteLine($"O resultado da divisão é {resultado}");
        //     Console.ReadKey();
        //     Menu();
        // }

        // static void Multiplicacao()
        // {
        //     Console.Clear();

        //     Console.WriteLine("Primeiro valor: ");
        //     float v1 = float.Parse(Console.ReadLine());

        //     Console.WriteLine("Segundo valor: ");
        //     float v2 = float.Parse(Console.ReadLine());

        //     Console.WriteLine("");

        //     float resultado = v1 * v2;
        //     Console.WriteLine("O resultado da multiplicação é " + (v1 * v2));
        //     Console.ReadKey();
        //     Menu();
        // }