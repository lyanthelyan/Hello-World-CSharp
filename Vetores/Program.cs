namespace Vetores;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {

        //! Programa para ler altura e falar a media, usando array
        Console.WriteLine("Quantidade: ");
        int n = int.Parse(Console.ReadLine());

        double[] meuArray = new double[n];

        for (int i = 0; i < n; i++)
        {
            meuArray[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        
        double sum = 0.0;

        for (int i = 0; i < n; i++)
        {
            sum += meuArray[i];
        }

        double media = sum / n;

        Console.WriteLine("Altura média: " + media.ToString("F2"));
    }
}
