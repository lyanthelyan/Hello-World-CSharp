namespace CotacaoDolar;

class ConversorDeMoeda{

    public static double iof = 0.06;
    public static double ConverterMoeda(double d, double v){
        double r =  d*v;  
        return (r * iof) + r;     
    }
}