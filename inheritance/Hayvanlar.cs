



public class Hayvanlar: Canlilar{
    protected void SuruHalindeHareket()
    {
        Console.WriteLine("Hayvanlar sürüler halinde hareket eder."); 
    }
}

// hayvanlar sinifindan miras alabilecek siniflar
// kalitim_alan : miras_veren
public class Kus:Hayvanlar
{
    public void Ucmak()
    {
        Console.WriteLine("Kuşlar uçar");
    }

    public Kus()
    {
        base.SuruHalindeHareket();
    }
}

public class Ordek:Hayvanlar
{
    public void Yuzmek(){
        Console.WriteLine("Ördekler yüzer");
    }

    public Ordek()
    {
        base.SuruHalindeHareket();
    }
}