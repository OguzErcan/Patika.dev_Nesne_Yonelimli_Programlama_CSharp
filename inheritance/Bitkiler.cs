



public class Bitkiler: Canlilar{
    protected void FotosentezYapmak(){
        Console.WriteLine("Bitkiler fotosentez yapar."); 
    }

    //// Polymorphism
    //// UyaranlaraTepki metotu sanal olarak yaratildigi yerdeki halini burada calistir
    public override void UyaranlaraTepki()
    {
        base.UyaranlaraTepki(); // üst sınıftaki komutları çalıştırır. // bu satir kapatilarak base class ignore edilebilirdi
        Console.WriteLine("Bitkiler güneşe tepki verir.");
    }
}

// bitkiler sinifindan miras alabilecek siniflar
public class TohumluBitkiler:Bitkiler
{
    public void TohumlaCogalma(){
        Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
    }
    
    //// TohumluBitkiler uzerinden FotosentezYapmak metoduna erisilemedi. Erisilebilmesi icin default constructor yazilmali
    public TohumluBitkiler()
    {
        base.FotosentezYapmak(); // base --> miras veren siniflarin metodlarina erisme sansi verir 
        // base.Beslenme();

        //// Polymorphism
        base.UyaranlaraTepki(); // nesnesi ilk olusturuldugunda cagrilsin diye default kurucu icerisinde yazilir. Program.cs icerisinde ornek nesnesi yaratilarak da cagrilabilirdi
    }
}

public class TohumsuzBitkiler:Bitkiler
{
    public void SporlaCogalma(){
        Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
    }

    public TohumsuzBitkiler()
    {
        base.FotosentezYapmak();
    }
}