// See https://aka.ms/new-console-template for more information

Console.WriteLine("***** Class ve Struct *****");

Dikdortgen dikdortgen = new Dikdortgen(); // veya --> Dikdortgen dikdortgen = new();
dikdortgen.KisaKenar = 3;
dikdortgen.UzunKenar = 4;
Console.WriteLine("Class Alan Hesabi: {0}", dikdortgen.AlanHesapla());

Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct(); // veya --> Dikdortgen_Struct dikdortgen_Struct;
dikdortgen_Struct.KisaKenar = 3;
dikdortgen_Struct.UzunKenar = 4;
Console.WriteLine("Struct Alan Hesabi: {0}", dikdortgen_Struct.AlanHesapla());


Console.WriteLine("***** Constructor Yapilari *****");

Dikdortgen dikdortgen1 = new Dikdortgen();
// dikdortgen1.KisaKenar = 3;
// dikdortgen1.UzunKenar = 4;
Console.WriteLine("Class Alan Hesabi: {0}", dikdortgen1.AlanHesapla());

Dikdortgen_Struct dikdortgen_Struct1 = new Dikdortgen_Struct(3, 4);
Console.WriteLine("Struct Alan Hesabi: {0}", dikdortgen_Struct1.AlanHesapla());




class Dikdortgen
{
    // fields
    public int KisaKenar;
    public int UzunKenar;

    public Dikdortgen()
    {
        KisaKenar = 3;
        UzunKenar = 4;
    }

    public long AlanHesapla()
    {
        return this.KisaKenar * this.UzunKenar;
    }
}

struct Dikdortgen_Struct
{
    // fields
    public int KisaKenar;
    public int UzunKenar;

    public Dikdortgen_Struct(int kisaKenar, int uzunKenar)
    {
        KisaKenar = kisaKenar;
        UzunKenar = uzunKenar;
    }

    public long AlanHesapla()
    {
        return this.KisaKenar * this.UzunKenar;
    }
}
