abstract class musico
{
    public string Nombre{ get;set;}
    public musico(string n){Nombre = n;}
    public void saluda (){Console.WriteLine($"Hola soy {Nombre}");}
    public /*virtual*/ abstract void Tocar(); 
    
    //{Console.WriteLine($"{Nombre}tocando su instrumento");}
}
 class bajista:musico
{
    public string bajo {get;set;}
    public bajista (string n,string b):base(n)
 {
    bajo=b;
 }
public override /*new*/ void Tocar()
  {
    Console.WriteLine($"{Nombre}tocando su {bajo}");
  }

 }

 class baterista:musico
 {
    public string bateria{get;set;}
    public baterista (string n,string b, string bt):base(n){
        bateria=bt;
    }

    public override /*new*/ void Tocar()
  {
    Console.WriteLine($"{Nombre}tocando su {bateria}");
  }

 }


internal class Program
{
    private static void Main(string[] args)
    {
        List<musico> Galgos = new List<musico>();
        //Galgos.Add(new musico("Manuel Medrano"));//
        Galgos.Add(new bajista("EL pa","Musicman"));

        foreach(var m in Galgos)m.saluda();
        foreach(var m in Galgos)m.Tocar();

       
        
        
        


    }
}
