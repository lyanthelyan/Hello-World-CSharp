namespace IMC;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Qual o seu peso? ");
        double peso = double.Parse(Console.ReadLine());
        
        Console.Write("Qual sua altura? ");
        double altura = double.Parse(Console.ReadLine());

        Console.WriteLine($"Seu IMC é de {calcularIMC(peso, altura):F2}");

    }
    
    
    static double calcularIMC(double peso, double altura)
    {
        return peso / (altura*altura);
    }
    
}
