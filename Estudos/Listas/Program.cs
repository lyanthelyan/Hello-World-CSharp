namespace Listas;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<string> Lista = new List<string>();
        
        Lista.Add("Alex");
        Lista.Add("Ana");
        Lista.Add("Bob");
        Lista.Add("Anna");
        Lista.Insert(2,"Marco");
        
        

        foreach (string item in Lista)Console.WriteLine(item);
        
        Console.WriteLine("List Count:" + Lista.Count);
        // string s1 = Lista.Find(Test);
        // Console.WriteLine("First Letter 'A': " + s1);
        
        // static bool Test(string s){
        //     return s[0] == 'A';
        // }

        //!Usando Lambda Para o First
        string s1 = Lista.Find(x => x[0] == 'A');
        Console.WriteLine("First Letter 'A': " + s1);
        string s2 = Lista.Last(x => x[0] == 'A');
        Console.WriteLine("Last Letter 'A': " + s2);

        int position1 = Lista.FindIndex(x => x[0] == 'A');
        Console.WriteLine("First Position 'A': " + position1);

        int position2 = Lista.FindLastIndex(x => x[0] == 'A');
        Console.WriteLine("Last Position 'A': " + position2);

        List<string> Lista2 = Lista.FindAll(x=> x.Length == 5); //! Filtrar somente na lista 1 os nomes que tem 5 caracteres
        Console.WriteLine("----------------");
        foreach (string item in Lista2)
        {
            Console.WriteLine(item);
        }

        Lista.RemoveRange(2,2); //! Remover a partir da posição 2, 2 elementos
        foreach (string item in Lista) Console.WriteLine(item);

        Console.WriteLine("----------------");
        Lista.Remove("Alex"); //!Remove pelo nome
        foreach (string item in Lista) Console.WriteLine(item);
        
        Console.WriteLine("----------------");
        
        Lista.RemoveAll(x => x[0] == 'M');//!Remove todos que começam com o caractere proposto
        foreach (string item in Lista) Console.WriteLine(item);
        
        Console.WriteLine("----------------");
        
        Lista.RemoveAt(1);//!Remove pela posição
        
        foreach (string item in Lista) Console.WriteLine(item);
        Console.WriteLine("----------------");
        
        

    }
}
