using System;

// Classe que representa um endereço
public class Endereco
{
    public string Rua { get; set; }      // Rua do endereço
    public string Cidade { get; set; }   // Cidade do endereço
    public string Estado { get; set; }   // Estado do endereço
    public string CEP { get; set; }      // CEP do endereço

    // Construtor da classe Endereco
    public Endereco(string rua, string cidade, string estado, string cep)
    {
        Rua = rua;
        Cidade = cidade;
        Estado = estado;
        CEP = cep;
    }
}

// Classe que representa um departamento dentro da escola
public class Departamento
{
    public string Nome { get; private set; }  // Nome do departamento

    // Construtor da classe Departamento
    public Departamento(string nome)
    {
        Nome = nome;
    }
}

// Classe que representa um aluno
public class Aluno
{
    public string Nome { get; set; }  // Nome do aluno
    public int Idade { get; set; }    // Idade do aluno

    // Construtor da classe Aluno
    public Aluno(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}

// Classe que representa uma escola
public class Escola
{
    private string nome;                  // Nome da escola
    private string CNPJ;                  // CNPJ da escola
    private Endereco endereco;            // Endereço da escola
    private Departamento[] departamentos; // Array de departamentos da escola
    private Aluno[] discentes;            // Array de alunos da escola
    private int nr_discentes;             // Número atual de alunos matriculados
    private int nr_departamentos;         // Número atual de departamentos criados

    // Construtor da classe Escola
    public Escola(string nome, string CNPJ)
    {
        this.nome = nome;
        this.CNPJ = CNPJ;
        this.departamentos = new Departamento[10]; // Inicializa o array de departamentos com tamanho 10
        this.discentes = new Aluno[1000];           // Inicializa o array de alunos com tamanho 1000
        this.nr_departamentos = 0;                  // Inicializa o contador de departamentos como 0
        this.nr_discentes = 0;                      // Inicializa o contador de discentes como 0
    }

    // Método para criar um novo departamento
    public void CriarDepartamento(string nomeDepartamento)
    {
        if (nr_departamentos < 10) // Verifica se o número máximo de departamentos não foi alcançado
        {
            departamentos[nr_departamentos] = new Departamento(nomeDepartamento); // Adiciona o novo departamento
            nr_departamentos++; // Incrementa o contador de departamentos
        }
        else
        {
            Console.WriteLine("Não é possível criar outro Departamento."); // Exibe uma mensagem de erro
        }
    }

    // Método para matricular um novo aluno
    public void MatricularAluno(Aluno novoAluno)
    {
        if (nr_discentes < 1000) // Verifica se o número máximo de discentes não foi alcançado
        {
            discentes[nr_discentes] = novoAluno; // Adiciona o novo aluno
            nr_discentes++; // Incrementa o contador de discentes
        }
        else
        {
            Console.WriteLine("Não é possível matricular mais alunos."); // Exibe uma mensagem de erro
        }
    }

    // Método para exibir as informações da escola
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Escola: {nome}"); // Exibe o nome da escola
        Console.WriteLine($"CNPJ: {CNPJ}"); // Exibe o CNPJ da escola
        Console.WriteLine("Departamentos:");
        for (int i = 0; i < nr_departamentos; i++) // Itera sobre o array de departamentos
        {
            Console.WriteLine($"- {departamentos[i].Nome}"); // Exibe o nome de cada departamento
        }
        Console.WriteLine("Discentes:");
        for (int i = 0; i < nr_discentes; i++) // Itera sobre o array de discentes
        {
            Console.WriteLine($"- {discentes[i].Nome}, Idade: {discentes[i].Idade}"); // Exibe o nome e a idade de cada aluno
        }
    }
}
class Program
{
    static void Main()
    {
        // Criar endereços para as escolas (não usado diretamente aqui, mas pode ser expandido)
        Endereco endereco1 = new Endereco("Rua Principal", "Cidade X", "Estado Y", "12345-678");
        Endereco endereco2 = new Endereco("Rua Secundária", "Cidade Y", "Estado Z", "87654-321");

        // Criar duas escolas
        Escola escola1 = new Escola("Escola ABC", "00.000.000/0000-00");
        Escola escola2 = new Escola("Escola XYZ", "11.111.111/1111-11");

        // Criar departamentos para as escolas
        escola1.CriarDepartamento("Matemática");
        escola1.CriarDepartamento("Física");

        escola2.CriarDepartamento("Química");
        escola2.CriarDepartamento("Biologia");

        // Criar alunos
        Aluno aluno1 = new Aluno("João", 15);
        Aluno aluno2 = new Aluno("Maria", 16);
        Aluno aluno3 = new Aluno("Pedro", 14);

        // Matricular alunos nas escolas
        escola1.MatricularAluno(aluno1);
        escola1.MatricularAluno(aluno2);

        escola2.MatricularAluno(aluno3);

        // Exibir informações das escolas
        Console.WriteLine("Informações da Escola 1:");
        escola1.ExibirInformacoes();

        Console.WriteLine("\nInformações da Escola 2:");
        escola2.ExibirInformacoes();
    }
}