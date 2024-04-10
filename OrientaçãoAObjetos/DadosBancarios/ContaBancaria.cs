namespace DadosBancarios;
using System.Globalization;

class ContaBancaria{

    public int NumeroBancario { get; private set;}
    public string NomeTitular { get; private set; }
    public double Saldo { get; private set; }

    public ContaBancaria(int numerobancario, string nometitular, double saldoinicial){
        NumeroBancario = numerobancario;
        NomeTitular = nometitular;
        Saldo = saldoinicial;
        
    }


    public double Depositar(double valor){
        return Saldo += valor;
    }
    
    public double Sacar(double valor){
        return Saldo -= valor;
    }
    


    public override string ToString()
    {
        return $"Conta {NumeroBancario}, Titular: {NomeTitular}, Saldo: R${Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
    }

}