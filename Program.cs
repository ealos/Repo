public class Padre
{
    public Padre() { }
    private void MetodoDaNonEstendere()
    {
        Console.WriteLine("Padre, metodo da non estendere.");
    }

    public void MtodoDaEstendere1()
    {
        Console.WriteLine("Padre, metodo da estendere 1.");
    }

    public void MtodDaoEstendere2()
    {
        Console.WriteLine("Padre, metodo da estendere 2.");
    }
}

public class Figlio : Padre
{
    public Figlio() { }

    // metodoDaEstendere1() non viene sovrascritto


    // sovrascrive, nasconde il metodo nella classe padre
    public new void MtodDaoEstendere2()
    {
        Console.WriteLine("Figlio, metodo esteso 2.");
    }
}

public class TheMain
{
    public static void Main(String[] args)
    {
        Padre father = new Padre();
        Figlio son = new Figlio();

        //father.metodoDaNonEstendere();   // Non è possibile richiamarlo è privato
        father.MtodoDaEstendere1();        // dalla classe padre
        father.MtodDaoEstendere2();        // dalla classe padre

        //son.metodoDaNonEstendere();      // Non è possibile richiamarlo è privato
        son.MtodoDaEstendere1();           // dalla classe padre 
        son.MtodDaoEstendere2();           // dalla classe figlio 

    }
}