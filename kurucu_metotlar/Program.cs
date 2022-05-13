// See https://aka.ms/new-console-template for more information
Console.WriteLine("***** Kurucu Metotlar *****");

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
//Calisan calisan1 = new Calisan();
//calisan1.Ad = "Ayse";
//calisan1.Soyad = "Kara";
//calisan1.No = 23415634;
//calisan1.Departman = "Insan Kaynaklari";

//calisan1.CalisanBilgileri();

//// nesneyi olsuturduktan sonra degiskenleri atamak yerine nesne olsuturulurken bunlar belirlenebilsin isteniyor
Calisan calisan1 = new Calisan("Ayse", "Kara", 23415634, "Insan Kaynaklari");
calisan1.CalisanBilgileri();

// yeni bir nesne yaratilmali (yeni bir calisan icin)
Calisan calisan2 = new Calisan();
calisan2.Ad = "Fikret";
calisan2.Soyad = "Kılınç";
calisan2.No = 11235813;
calisan2.Departman = "Satin Alma";

calisan2.CalisanBilgileri();



Calisan calisan3 = new Calisan("Bulent", "Ortacgil");
calisan3.CalisanBilgileri();


class Calisan
{
    // properties
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    
    //// nesneye deger atama (nesne ayaga kaldirma) islemini kurucu metot ile yaptirmak istenmekte (kod refactor edilmis olunur)
    //// kurucu metod public olmali ve class ismi ile ayni isimde olmali
    //// kurucu metod sinifin ozellikleri uzerinde degislik yapabilir. bir sınıf ayaga kalktiginde nesnesi olustururken bunun ilk degerleri atanabilir olmasi istenmekte
    public Calisan(string ad, string soyad, int no, string departman)
    {
        this.Ad = ad; // bu sinifin elemani demek (this.Ad). ad: bu metota gelen parametre. ----- Ad = ad seklinde de yazilabilirdi
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
    }
    //// disaridan 4 tane degisken alan ve bu sinifin ozelliklerini set eden bir kurucu olusturuldu

    //// hic parametre almayan bir kurucu -- overload 
    public Calisan(){}
    //// mevcut metotlar ve nesne atamalari calismaya devam edecek 

    //// overload
    public Calisan(string ad, string soyad)
    {
        this.Ad = ad; 
        this.Soyad = soyad;
    }

    // bilgileri getiren metot
    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışanın Adı: {0}", Ad);
        Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
        Console.WriteLine("Çalışanın Numarası: {0}", No);
        Console.WriteLine("Çalışanın Departmnı: {0}", Departman);
    }
}

