namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        var meuArray = new int[5]{12,4,3,2,5};
        
        var funcionarios = new Funcionario[5];
        funcionarios[0] = new Funcionario(){Id = 2579, Nome = "Andre"};
        
        var arr = new int[4];
        // var arrb = arr; //! Arrays são de referencias, então ele não criou uma copia, se mudar o arrb vai mudar o arr, e se mudar o arr vai mudar para o arrb, para criar uma copia, necessita usar o NEW
        var arrb = new int[4];

        arr[0] = 23;
        Console.WriteLine(arrb[0]);


        // Console.WriteLine(meuArray[0]);
        // Console.WriteLine(meuArray[1]);
        // Console.WriteLine(meuArray[2]);
        // Console.WriteLine(meuArray[3]);
        // Console.WriteLine(meuArray[4]);

        // for(var i = 0; i < meuArray.Length; i++){
        //     Console.WriteLine(meuArray[i]);
        
        // }

        // foreach (var funcionario in funcionarios){
        //     Console.WriteLine(funcionario.Nome);
            
        // }

            
    } 

    public struct Funcionario{
        public int Id{get;set;}
        public string Nome{get;set;}
    }
}
