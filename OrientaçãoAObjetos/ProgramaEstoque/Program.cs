namespace ProgramaEstoque;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
         
        // int qte;

        // Console.WriteLine("Entre os dados do produto:");
        
        // Console.Write("Nome: ");
        // string nome = Console.ReadLine();
        
        // Console.Write("Preço: ");
        // double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Console.Write("Quantidade no estoque: ");
        // int quantidade = int.Parse(Console.ReadLine());

        // // Produto p = new Produto(nome, preco); //! Construtor Sobrecarga ( Mais de um construtor)
        
        // Produto p2 = new Produto(); //! COnstrutor Padrão

        // Produto p = new Produto(nome, preco, quantidade); //! 

        // Console.Clear();

        // Console.WriteLine($"Dados do produto: {p}");
        // Console.WriteLine("");

        // Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
        // qte = int.Parse(Console.ReadLine());
        // p.AdicionarProdutos(qte);
        // Console.WriteLine();
        // Console.WriteLine($"Dados atualizados do produto: {p}");
        
        // Console.WriteLine();

        // Console.Write("Digite o número de produtos a ser removido no estoque: ");
        // qte = int.Parse(Console.ReadLine());
        // p.RemoveProdutos(qte);
        // Console.WriteLine();
        // Console.WriteLine($"Dados atualizados do produto: {p}");


        //*ENCAPSULAMENTO
        //? Vantagens de encapsulamento, é proteção, e colocar lógicas, Linha 30

        Produto p = new Produto("Tv", 500.00, 10);
        
        //*Obter o nome
        //Console.WriteLine(p._nome); //!Não irá funcionar pq o _nome é privado, assim foi criado um método get, setter
        Console.WriteLine(p.GetNome());
        //*Mudar o nome
        // p._nome = "TV 4K"; //! Não irá funcionar, por isso criamos o metodo para mudar
        p.SetNome("TV 4K");
        // Console.WriteLine(p.GetNome());

        // Console.WriteLine(p.GetPreco());
        // Console.WriteLine(p.GetQuantidade());

        //* Usando proprietier (linha 26) podemos imprimir o nome sem precisar usar a forma GetNome
        Console.WriteLine(p.Nome);
        p.Nome = "T";
        Console.WriteLine(p.Quantidade);
        Console.WriteLine(p.Preco);

        


    }
}
