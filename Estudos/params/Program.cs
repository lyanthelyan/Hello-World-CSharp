namespace paramsestudo;

class Program
{
    //!EXPLICAÇÃO METODO PARAMS, CADERNO PAGINA 5
    static void Main(string[] args)
    {
        // Console.WriteLine(Soma(1,2));
        //!Metodo Array
        // int result = Soma(new int[]{1,10,2});
        // Console.WriteLine(result);
        //*Metodo Params
        Console.WriteLine(Soma(1,2,3,4));

    }


    //! Metodo feio para fazer soma de varios valores
    // public static double Soma(double n1, double n2)
    // {
    //     return n1+n2;
    // }
    // public static double Soma(double n1, double n2, double n3)
    // {
    //     return n1+n2+n3;
    // }
    // public static double Soma(double n1, double n2, double n3, double n4)
    // {
    //     return n1+n2+n3+n4;
    // }

    //! Metodo usando array
    // public static int Soma(int[] numbers)
    // {
    //     int sum=0;
    //     for (int i = 0; i < numbers.Length; i++)
    //     {
    //         sum+=numbers[i];
    //     }
    //     return sum;
    // }
    //*Metodo Params
    public static int Soma(params int[] numbers)
    {
        int sum=0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum+=numbers[i];
        }
        return sum;
    }
    

}
