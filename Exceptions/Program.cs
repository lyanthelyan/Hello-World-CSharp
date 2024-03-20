namespace Exceptions;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int [] array = {1,2,3};

        try
        {
            // for (int index = 0; index < 10; index++){
            // //* System.IndexOutOfRangeException
            // Console.WriteLine(array[index]);
            // }

            Cadastrar("asd"); //! Texto está nulo ou vazio
        
        //! Pode colocar o nome também da exeção usando catch(Execption (nome, da excecão))
        //! Podemos ter varios Catchs
        }
        catch(IndexOutOfRangeException ex) //! Catch especifico.
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine($"Não encontrei o índice na lista: {ex.Message}");
        }
        catch(ArgumentNullException ex)
        {
            Console.WriteLine($"Falha ao cadastrar o texto: {ex.Message}");
        }
        catch(MinhaException ex)
        {
            Console.WriteLine($"Falha ao cadastrar o texto: {ex.Message}");
            Console.WriteLine(ex.QuandoAconteceu);
        }
        catch(Exception ex) //! Catch genérico. Desconhecido.
        {
            Console.WriteLine($"Ops, algo deu errado: {ex.Message}"); //! Throw new Execption cria uma Exceção, estão o Metodo Message, irá disparar o que a gente criou
        }
        finally
        {
            Console.WriteLine("O finally sempre vai acontecer, mesmo com os erros");
        }
        
    }

    //*Custom Exception

    public class MinhaException : Exception
    {
        public MinhaException (DateTime date)
        {
            QuandoAconteceu = date;
        }
        public DateTime QuandoAconteceu {get;set;}
    }

    static void Cadastrar(string texto)
    {
        if(string.IsNullOrEmpty(texto))
            // throw new Exception("O texto não pode ser nulo ou vazio"); //! Disparando uma nova Exceção Generica
            throw new ArgumentNullException("Não pode ser nulo"); //! Erro especifico
    }
}
