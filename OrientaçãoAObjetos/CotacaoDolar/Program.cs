namespace CotacaoDolar;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        Console.Write("Qual a cotação do dolar: ");
        double dolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        Console.Write("Quantos dólares você vai comprar: ");
        double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        double resultado = ConversorDeMoeda.ConverterMoeda(valor, dolar);

        Console.WriteLine($"Valor a ser pago em Reais: {resultado.ToString("F2", CultureInfo.InvariantCulture)}");

    }


}
