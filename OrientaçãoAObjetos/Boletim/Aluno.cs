namespace Boletim;

class Aluno{
    
    public string Nome;

    public double Nota1;
    public double Nota2;
    public double Nota3;

    

    public double NotaFinal(){
        return Nota1 + Nota2 + Nota3;
    }

    public bool Aprovado(){
        if (NotaFinal() >= 60) return true; else return false;
    }

    public double NotaRestante(){
        return 60-NotaFinal();
    }

    public double VerificarNota(double nota, double limite) {
        while (nota > limite) {
            Console.Write($"Nota acima do esperado ({limite}). Digite novamente: ");
            nota = double.Parse(Console.ReadLine());
        }
        return nota;
    }
    
}