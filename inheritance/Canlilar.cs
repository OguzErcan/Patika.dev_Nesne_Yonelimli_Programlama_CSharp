public class Canlilar {
    public void Beslenme()
    {
        Console.WriteLine("Canlılar beslenir.");        
    }

    public void Solunum()
    {
        Console.WriteLine("Canlılar solunum yapar."); 
    }

    public void Bosaltim()
    {
        Console.WriteLine("Canlılar boşaltım Yapar."); 
    }

    //// Polymorphism
    public virtual void UyaranlaraTepki()
    {
        Console.WriteLine("Canlılar uyaranlara tepki verir.");
    }
}