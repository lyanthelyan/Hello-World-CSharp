namespace Calculadora;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        

        Console.WriteLine("Entre o valor do raio: ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double circ = Calc.Circunferencia(raio);
        double volume = Calc.Volume(raio);

        Console.WriteLine($"Circunferência: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Valor do Pi: {Calc.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
