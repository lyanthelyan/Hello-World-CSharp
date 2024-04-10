namespace Funcionario;
using System.Globalization;

class FuncionarioClass{

    public string Nome;
    public double Imposto;
    public double SalarioBruto; 

    public double SalarioLiquido(){
        return SalarioBruto - Imposto;
    }

    public double AumentarSalario(double porcentagem){
       return SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);



    }

    public override string ToString()
    {
        return $"{Nome}, R${SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
    }
}