namespace LerNome;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //*Ler apenas o Nome
        // Console.Clear();
        // Pessoa a, b;

        // a = new Pessoa();
        // b = new Pessoa();

        // Console.Write("Qual o nome da pessoa (A): ");
        // a.Nome = Console.ReadLine();
        // Console.Write("Qual a idade da pessoa (A): ");
        // a.Idade = int.Parse(Console.ReadLine());

        // Console.Clear();

        // Console.Write("Qual o nome da pessoa (B): ");
        // b.Nome = Console.ReadLine();
        // Console.Write("Qual a idade da pessoa (B): ");
        // b.Idade = int.Parse(Console.ReadLine());

        // Console.Clear();
        
        // Console.WriteLine($"Dados da primeira pessoa:\nNome: {a.Nome}\nIdade: {a.Idade}");
        
        // Console.WriteLine("");

        // Console.WriteLine($"Dados da segunda pessoa:\nNome: {b.Nome}\nIdade: {b.Idade}");

        // Console.WriteLine("");

        // if (a.Idade > b.Idade){
        //     Console.WriteLine($"Pessoa mais velha: {a.Nome}");
        // }else if (b.Idade > a.Idade){
        //     Console.WriteLine($"Pessoa mais velha: {b.Nome}");
        // }else{
        //     Console.WriteLine("As pessoas têm a mesma idade.");
        // }

        //*Ler Nome e Salario
    
        Console.Clear();
        Pessoa a,b;

        a = new Pessoa();
        b = new Pessoa();

        Console.Write("Qual o nome do funcionário (A): ");
        a.Nome = Console.ReadLine();
        Console.Write("Qual o salário do funcionário (A): ");
        a.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Clear();

        Console.Write("Qual o nome do funcionário (B): ");
        b.Nome = Console.ReadLine();
        Console.Write("Qual o salário do funcionário (B): ");
        b.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Clear();

        Console.WriteLine($"Dados da primeira pessoa:\nNome: {a.Nome}\nSalario: {a.Salario:F2}");
        Console.WriteLine("");
        Console.WriteLine($"Dados da segunda pessoa:\nNome: {b.Nome}\nSalario: {b.Salario:F2}");
        Console.WriteLine("");

        Console.WriteLine($"Salário médio: {(a.Salario+b.Salario)/2:F2}");




    }
}

class Pessoa
{
    public string Nome;
    public int Idade;
    public double Salario;
}
