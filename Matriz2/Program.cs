namespace Matriz2;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Linha: ");
        int l = int.Parse(Console.ReadLine());
        Console.Write("Coluna: ");
        int c = int.Parse(Console.ReadLine());

        int[,] matriz = new int[l, c];

        for (int i = 0; i < l; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');

            for (int j = 0; j < c; j++)
            {
                matriz[i, j] = int.Parse(valores[j]);
            }
            
        }

        Console.Write("Escolhe o número a ser localizado: ");
        int x = int.Parse(Console.ReadLine());

        for (int i = 0; i < l; i++)
        {
            for (int j = 0; j < c; j++)
            {
                if (matriz[i, j] == x)
                {
                    Console.WriteLine($"Position {i},{j}:");

                    if (j > 0)
                    {
                        Console.WriteLine($"Left: {matriz[i, j - 1]}");
                    }
                    if (i > 0)
                    {
                        Console.WriteLine($"Up: {matriz[i - 1, j]}");
                    }
                    if (j < c - 1)
                    {
                        Console.WriteLine($"Right: {matriz[i, j + 1]}");
                    }
                    if (i < l - 1)
                    {
                        Console.WriteLine($"Down: {matriz[i + 1, j]}");

                    }
                } 
      

    
            }
        }

    } 
          
}          