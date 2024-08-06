namespace EstudoTeste;
class Estudo{

   public string Name { get; set; }
   public string Email { get; set; }
   public int Room { get; set; }

   public Estudo(string name, string email, int room){
    Name=name;
    Email=email;
    Room=room;
   }
}