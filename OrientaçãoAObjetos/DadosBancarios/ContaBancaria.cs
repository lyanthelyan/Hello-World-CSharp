namespace DadosBancarios;
using System.Globalization;

class ContaBancaria{

    public int NumeroBancario { get; private set;}
    public string NomeTitular { get; set; }
    public double Saldo { get; private set; }

    public ContaBancaria(int numerobancario, string nometitular){
        NumeroBancario = numerobancario;
        NomeTitular = nometitular;
        
    }
    
    //!Brincando como usar o construtor de 3 argumentos
    public ContaBancaria( int numerobancario, string nometitular, double saldo) : this(numerobancario, nometitular){
        Saldo = saldo;
        //!Em vez de usar o saldo referenciado ao saldoinicial, podemos chamar a função (Depositar(saldo))
        //? é muito melhor colocar a operação Depositar() pq se alguma regra na operação for mudada não irá mudar no construtor
    }


    public double Depositar(double valor){
        return Saldo += valor;
    }
    
    public double Sacar(double valor){
        return Saldo -= valor + 5.0;
    }
    


    public override string ToString()
    {
        return $"Conta {NumeroBancario}, Titular: {NomeTitular}, Saldo: R${Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
    }

}