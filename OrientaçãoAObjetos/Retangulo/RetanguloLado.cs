namespace Retangulo;

class RetanguloLado{
    public double Altura;
    public double Largura;


    public double Area(){
        
        double area = Altura * Largura;
        return area;
    }

    public double Perimetro(){
        double perimetro = 2*(Altura + Largura);
        return perimetro;
    }

    public double Diagonal(){
        double diagonal;
        diagonal = Math.Sqrt(Math.Pow(Largura,2)+(Math.Pow(Altura,2)));
        return diagonal;

        
    }
}

//d2 = b2 + h2 