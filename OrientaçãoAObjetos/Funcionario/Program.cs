namespace Funcionario;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        FuncionarioClass funcionario;
        funcionario = new FuncionarioClass();

        Console.Write("Nome do Funcionário: ");
        funcionario.Nome = Console.ReadLine();
        
        Console.Write("Salário Bruto: ");
        funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        Console.Write("Imposto: ");
        funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine($"Funcionário: {funcionario}");
        Console.WriteLine();

        Console.Write("Digite a porcentagem para aumentar o salário: ");
        double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        funcionario.AumentarSalario(porcentagem);

        Console.WriteLine($"Dados atualizados: {funcionario}");
        

        
    

        

    }
}
