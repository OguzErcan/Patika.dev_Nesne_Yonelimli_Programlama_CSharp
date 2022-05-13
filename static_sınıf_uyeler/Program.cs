// See https://aka.ms/new-console-template for more information
Console.WriteLine("***** Static Sinif ve Uyeleri *****");


// baslagicta sirketin calisan sayisi gorulsun
Console.WriteLine("Calisan Sayisi           : {0}", Calisan.CalisanSayisi); // Calisan sinifinin static olan uyelerine erismek icin --> Calisan.CalisanSayisi

// Calisan sinifindan bir nesne yaratiliyor cunku static olmayan fieldlar setlenmek istenmekte
Calisan calisan = new Calisan("Ayse", "Yilmaz", "IK"); // fieldlari setleniyor / private olduklari icin kurucu uzerinden setleniyor
Console.WriteLine("Calisan Sayisi           : {0}", Calisan.CalisanSayisi);
// Calisan sinifinin hem 3 parametre alan public hem de static bir kurucusu var, hangisi once calisir? Calisan sinifindan bir nesne olusturuldugunda her seferinde public olan kurucusu calisir ama Calisan sinifinin static olan kurucusu sadece sinifa ilk erisildiginde calisir. Baslingicta 6. satirdaki komut degil 9. satirdaki komut calistirilmis olunursa Calisan sinifinin static olan kurucusuna gidilecek daha sonra diger kurucusu calistirilacak. 6. satir calistirilirsa Calisan sinifina erismek istenildigi icin buna erismeden once gidip static kurucu calistirilacak daha sonra get fonksiyonu araciligiyla calisan sayisi getirilecek
Calisan calisan1 = new Calisan("Ali", "Kaya", "Satin Alma");
Calisan calisan2 = new Calisan("Veli", "Korkmaz", "Pazarlama");
Console.WriteLine("Calisan Sayisi           : {0}", Calisan.CalisanSayisi);

// static sınıfın uyelerine erismek icin Sinifadi.Uye kullanilir. nesnesi olusturulmaz
Console.WriteLine("Toplama islemi sonucu: {0}", Islemler.Topla(100, 200));

Console.WriteLine("Cikarma isleminin sonucu: {0}", Islemler.Cıkar(200, 100));


// sınıfın adiyla erişilebilir. nesne olusturulmaz 
// (static olmayan classlar icin) static olmayan uyeler o sinif icerisinde nesneye ozguyken (nesnesine ozel setlenir ve getirilir); static olan uyeler sinif bazinda atanir (kendilerine atanan veriyi tutarlar)

class Calisan
{
    private static int calisanSayisi; // field (degisken)

    // encapsulate
    public static int CalisanSayisi { get => calisanSayisi; } //property

    // property leri olusturulmayacak cunku bu ozelliklere sinif disindan erisilmesi istenmiyor. sadece kurucusu araciligiyla bunlar set edilmek isteniyor, disaridan get edilmeyecekler (yani sadece kurucusunda erisilebilir fieldlar yaratildi)
    private string Isim;
    private string  Soyisim;
    private string Departman;

    // static kurucu -- erisim belirteci olmaz
    static Calisan()
    {
        // static olan field setleniyor
        calisanSayisi = 0;
    }

    // kurucu
    public Calisan(string ısim, string soyisim, string departman)
    {
        // atamalar 
        this.Isim = ısim;
        this.Soyisim = soyisim;
        this.Departman = departman;
        // nesnesi yaratilirken bu fieldlar setlenmiş oldu

        // calisanlar kurucular araciligiyla belirlenir. field private yapilmisti ve public property in set fonksiyonu da kapatildi; boylece, calisan sayisi yalnizca Calisan classi icerisinden degistirilebilir olacak. Disaridan propertye (public static) erisilmek istendiginde private olan calisanSayisi fieldı dondurulecegi icin artirilmis olan donecek. Her Calisan classından bir nesne olusturulmasi isleminde static olan calisanSayisi 1 artirilmis olacak
        calisanSayisi ++;
    }
}

// static sınıf
static class Islemler
{
    // metotlar
    public static long Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }

    public static long Cıkar(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }
}