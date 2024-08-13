using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
{
    static void Main()
    {
        Cachorro meuCachorro = new Cachorro("Rex");


        Console.WriteLine("Teste");
        meuCachorro.Comer();
        meuCachorro.Dormir();
        Console.WriteLine();
        meuCachorro.Latir();  
        
    }
}

class Animal
{

    public string Nome { get; set; }

    public Animal(string name)
    {
        Nome=name;
    }     

    public void Comer()
    {
        Console.WriteLine($"O {Nome} está comendo");
    } 
    public void Dormir()
    {
        Console.WriteLine($"O {Nome} está dormindo");
    }      
}
class Cachorro : Animal
{
    public Cachorro(string nome) : base(nome){}

    public void Latir()
    {
        Console.WriteLine($"O {Nome} está latindo");
    }
}

