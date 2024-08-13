namespace Matrizes;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // double[,] matriz = new double[2,3]; //! 2 Linhas e 3 Colunas
        // Console.WriteLine(matriz.Length);
        // Console.WriteLine(matriz.Rank); //! Quantidade de Linhas
        // Console.WriteLine(matriz.GetLength(0)); //! Primeira dimensao da matriz tem quantidade 2
        // Console.WriteLine(matriz.GetLength(1)); //! Segunda dimensao da matriz tem qunatidade 3

        // foreach (var item in matriz)
        // {
        //     Console.WriteLine(item);
        // }

        //* Exercicios Resolvido: Fazer um programa para ler um número inteiro N e uma matriz de ordem N contendo números inteiros. Em seguida, mostrar a diagonal principal e a quantidade de valores negativos da matriz.


        // Console.Write("Tamanho da Matriz: ");
        // int n = int.Parse(Console.ReadLine());
        // int[,] mat = new int[n,n];

        
        // for (int i = 0; i < mat.GetLength(0); i++)
        // {
        //   for (int p = 0; p < mat.GetLength(1); p++)
        //   {
        //     mat[i, p] = int.Parse(Console.ReadLine());
        //   }  
        // }
        
        // Console.WriteLine();
        
        // for (int i = 0; i < mat.GetLength(0); i++)
        // {
        //     for (int j = 0; j < mat.GetLength(1); j++)
        //     {
        //         Console.Write(mat[i, j] + " ");
        //     }
        //     Console.WriteLine();
        //  }

        // Console.WriteLine();
         
        // int c = 0;
        
        // for (int i = 0; i < mat.GetLength(0); i++)
        // {
            
        //     for (int j = 0; j < mat.GetLength(1); j++)
        //     {
        //         if(mat[i,j]<0){
        //             c+=1;
        //         }
                
        //     }
        // }
        // Console.WriteLine("Diagonal Principal:");
        
        // for (int i = 0; i < mat.GetLength(0); i++)
        
        // {
        //     Console.Write(mat[i, i] + " ");
        // }
        
        // Console.WriteLine();
        // Console.WriteLine($"Negative Numbers: {c}");

        //*Codigo Professor
        int n = int.Parse(Console.ReadLine());

        int[,] mat = new int [n, n];

        for (int i = 0; i < n; i++)
        {
            string[] values = Console.ReadLine().Split(' ');
            
            for (int j = 0; j < n; j++)
            {
                mat[i,j] = int.Parse(values[j]); //! Como o vetor est[a em string, voce digita um numero e na linha i(0) e coluna j(0) ira esse numero, o loop vai ser chamado de novo e ira ser linha i(1) coluna i(1) e por assim diante ]]
            }
        }

    }   

}       
