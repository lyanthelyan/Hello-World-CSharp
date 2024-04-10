namespace Boletim;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Aluno alunos;
        alunos = new Aluno();

        Console.Write("Nome do Aluno: ");
        alunos.Nome = Console.ReadLine();
        
       
            Console.WriteLine("Digite as 3 notas do aluno:");
            
            Console.Write("Nota1: ");
            alunos.Nota1 = alunos.VerificarNota(double.Parse(Console.ReadLine()), 30);

            Console.Write("Nota2: ");
            alunos.Nota2 = alunos.VerificarNota(double.Parse(Console.ReadLine()), 35);
            
            Console.Write("Nota3: ");
            alunos.Nota3 = alunos.VerificarNota(double.Parse(Console.ReadLine()), 35);

        Console.WriteLine($"Nota Final = {alunos.NotaFinal()}");
        
        if (alunos.Aprovado()) Console.WriteLine("Aprovado!"); else Console.WriteLine($"Reprovado\nNota Restante: {alunos.NotaRestante()}");
        System.Console.WriteLine();


        


        


    }
}
