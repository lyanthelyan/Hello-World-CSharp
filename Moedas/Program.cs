using System.Globalization;
namespace Moedas;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        
        decimal valor = 123535m; //!Decimal tem mais precisão do que double e float. Preço e salário é bom também usar decimal
        // Console.WriteLine(valor.ToString(
        //     "C", //! C significa currency, então vai formatar usando o padrão de moeda. 
        //     CultureInfo.CreateSpecificCulture("en-US"))
        //     );

        Console.WriteLine(
            Math.Round(valor)
        );
    }
}
