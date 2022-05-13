// See https://aka.ms/new-console-template for more information
Console.WriteLine("***** Sinif Kavrami *****");

// class SinifAdi
// {
//    [Erisim Belirteci] [Veri tipi] OzellikAdi;
//    [Erisim Belirteci] [Geri donus tipi] MetotAdi ([Parametre]);
//    {
//       // Metot komutlari    
//    }  
// }

// Erisim belirtecleri --> public, private, internal, protected


// Calisan class'inin bir örnegi(instance) yaratilmali
Calisan calisan1 = new Calisan();
calisan1.Ad = "Ayse";
calisan1.Soyad = "Kara";
calisan1.No = 23415634;
calisan1.Departman = "Insan Kaynaklari";

calisan1.CalisanBilgileri();


// yeni bir nesne yaratilmali (yeni bir calisan icin)
Calisan calisan2 = new Calisan();
calisan2.Ad = "Fikret";
calisan2.Soyad = "Kılınç";
calisan2.No = 11235813;
calisan2.Departman = "Satin Alma";

calisan2.CalisanBilgileri();



class Calisan
{
    // properties
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    // bilgileri getiren metot
    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışanın Adı: {0}", Ad);
        Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
        Console.WriteLine("Çalışanın Numarası: {0}", No);
        Console.WriteLine("Çalışanın Departmnı: {0}", Departman);
    }
}
