public class Figlio
{
    public Figlio() { }

    Padre senior = new Padre();


    public void MetodoDaEstendere2()
    {
        Console.WriteLine("Figlio, sono un altro metodo con la stessa signature.");
    }

    public static void Main(String[] args)
    {
        Padre father = new Padre();
        Figlio son = new Figlio();

        //son.MetodoDaEstendere1();        // non esiste qui e non può vedere (con questa sintassi) l'omonimo nella classe Padre 
        son.MetodoDaEstendere2();          // dalla classe Figlio, non ricopre, non vede l'omonimo nella classe Padre
       
        son.senior.MetodoDaEstendere1();   // dalla classe Padre attraverso senior
        son.senior.MetodoDaEstendere2();   // dalla classe Padre attraverso senior
    }
}