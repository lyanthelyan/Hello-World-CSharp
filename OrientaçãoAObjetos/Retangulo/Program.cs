namespace Retangulo;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        RetanguloLado retangulo;
        retangulo = new RetanguloLado();
        
        Console.WriteLine("Entre a largura e a altura do retângulo:");
        retangulo.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        retangulo.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        Console.WriteLine($"ÁREA: {retangulo.Area().ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Perímetro: {retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Diagonal: {retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");

    }
}