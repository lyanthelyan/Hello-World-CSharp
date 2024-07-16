namespace Ref_Out;

class Program
{
    static void Main(string[] args)
    {
        // int a = 10; // !Não se esqueça que é um tipo valor, não irá mudar o valor na class Calculator porque irá apenas fazer uma cópia
        // Calculator.Triple(a);
        // Console.WriteLine(a);

        //*Usando o método ref
        // int a = 10;
        // Calculator.Triple(ref a);
        // Console.WriteLine(a);

        //*Usando Out

        int a = 10;
        int triple;
        Calculator.Triple(a, out triple);
        Console.WriteLine(triple);

    }

    // class Calculator{
    //     public static void Triple(int x){
    //         x*=3;
    //     }
    // }

    //*Usando o método ref
    // class Calculator{
    //     public static void Triple(ref int x){
    //         x*=3;
    //     }
    // }

    //*Usando Out
    class Calculator{
        public static void Triple(int origin, out int result){
            result = origin *3;
        }
    }
}
