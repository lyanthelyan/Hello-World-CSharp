namespace ProgramaEstoque;
using System.Globalization;

class Produto{
    private string _nome; //* underline, é para mostrar que o atributo é privado
    private double _preco;
    private int _quantidade; //* Encapsulamento, trocando o atributo para private, encapsula o programa para que o usuário não precise mexer por dentro
    
    //*-----------------------------------------------------------------------------------------------
    //* Propriedade AutoImplementada

    public double Preco { get; private set;}
    public int Quantidade {get; private set;}
    // public string Nome {get; private set;} //! COmo nome possue uma lógica particula, usando if, não usaremos a propriedade AutoImplementada

    




    //*-----------------------------------------------------------------------------------------------
    
    public Produto(){}
    //*Método Construtor
    
    // public Produto(string nome, double preco, int quantidade ){
    //     Nome = nome;
    //     Preco = preco;
    //     Quantidade = quantidade;
    // }
    public Produto(string nome, double preco, int quantidade ){
        _nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }
    //*-----------------------------------------------------------------------------------------------
    //*Usando Propriedade, Que é muito melhor que o encapsulamento normal usando Getnome, setNome

    public string Nome {    
        get {return _nome;}
        set {
            if (value != null && value.Length > 1){
            _nome = value;
            };
        }
    }

    // public double Preco{
    //     get {return _preco;}  //! Utilizando o public double Preco { get; private set} dispensa esse método
    // }

    // public int Quantidade {
    //     get{return _quantidade; } //!Utilizando o public int Quantidade {get; private set;} dispensa esse método
    // }
    //*-----------------------------------------------------------------------------------------------
    
    //*-----------------------------------------------------------------------------------------------
    //*Metodo para obter nome do produto
    //! Como o _nome é privado, o usuario nao irá conseguir usar Console.writeline(p.nome)
    public string GetNome() {              
        return _nome;
    }


    //*Metodo para alterar o nome
    //? Colocando lógica, só irá aceitar a mudança de nome, se ele não for nulo e tiver mais de 1 caractere
    public void SetNome(string nome){
        if (nome != null && nome.Length > 1){
            _nome = nome;
        }
    }

    public double GetPreco(){
        return _preco;
    }

    public int GetQuantidade(){
        return _quantidade;
    }
    //*-----------------------------------------------------------------------------------------------

    // public double ValorTotalEmEstoque(){
    //     return Preco * Quantidade;
    // }
    public double ValorTotalEmEstoque(){
         return Preco * Quantidade;
     }


    // public void AdicionarProdutos(int quantidade){
    //     Quantidade += quantidade;
    // }
    public void AdicionarProdutos(int quantidade){
        Quantidade += quantidade;
    }

    // public void RemoveProdutos(int quantidade){
    //     Quantidade -= quantidade;
    // }
    public void RemoveProdutos(int quantidade){
        Quantidade -= quantidade;
    }



    // public override string ToString()
    // {
    //     return $"{Nome}, R${Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades,  Total: R${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
    // }
    public override string ToString()
    {
        return $"{_nome}, R${Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades,  Total: R${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
    }
}