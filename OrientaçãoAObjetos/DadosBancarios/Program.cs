namespace DadosBancarios;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        
        Console.Write("Entre o número da conta: ");
        int numerobancario = int.Parse(Console.ReadLine());

        Console.Write("Entre o Titular da conta: ");
        string nometitular = Console.ReadLine();
        nometitular = char.ToUpper(nometitular[0]) + nometitular.Substring(1);

        double saldo = 0;
        
        while (true){
            Console.Write("Haverá depósito inicial?(s/n): ");
            var respostaDepositoInicial = (Console.ReadLine().ToLower());
            
            if (respostaDepositoInicial == "s")
            {
                Console.Write("Entre o valor do depósito inicial: ");
                saldo = double.Parse(Console.ReadLine());
                break;
            
            }
            else if (respostaDepositoInicial == "n")
            {
                Console.WriteLine("Entendido, não haverá depósito inicial.");
                break;
            
            }   
            else
            {
                Console.WriteLine("Resposta inválida. Por favor, responda apenas com 's' ou 'n'.");
            
            };
        }
        
        ContaBancaria c = new ContaBancaria(numerobancario, nometitular, saldo);
        
        Console.WriteLine();
        Console.WriteLine("Dados da Conta:");
        Console.WriteLine(c);
        Console.WriteLine();

        Console.Write("Entre um valor para depósito: ");
        double deposito = double.Parse(Console.ReadLine());

        c.Depositar(deposito);

        Console.WriteLine();
        Console.WriteLine("Dados da Conta:");
        Console.WriteLine(c);
        Console.WriteLine();

        Console.Write("Entre um valor para saque (Taxa de 5%): ");
        double saque = double.Parse(Console.ReadLine());

        c.Sacar(saque);
        
        Console.WriteLine();
        Console.WriteLine("Dados da Conta:");
        Console.WriteLine(c);
        Console.WriteLine();

        



        

        

        
    }
}
