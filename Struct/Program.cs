namespace Struct;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Point p;  //! Não precisa fazer Point p = new Point(), Porque é um tipo valor, a simples declaração ja vai criar as caixinhas no stack da memória, no entanto, aceita o comando new
        p.X = 10;
        p.Y = 20;
        Console.WriteLine(p);
        p = new Point(); 
        Console.WriteLine(p);
    }
    
}

struct Point{
    public double X;
    public double Y;

    public override string ToString()
    {
        return $"({X} , {Y})";
    }
}
