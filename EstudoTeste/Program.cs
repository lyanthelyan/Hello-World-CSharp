namespace EstudoTeste;

class Program
{
    static void Main(string[] args)
    {
     string[] vect = new string[5];
     vect[0]="Maria";
     vect[1]="Alex";
     vect[2]="Bob";
     vect[3]="Smith";
     vect[4]="John";
     
     
      foreach (string item in vect){
         Console.WriteLine(item);
         Console.WriteLine();
      }
    }

}
