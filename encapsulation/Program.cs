// See https://aka.ms/new-console-template for more information
Console.WriteLine("***** Encapsulation *****");


// Ogrenci class ının bir nesnesi yaratiliyor (instance)
Ogrenci ogrenci1 = new Ogrenci();
ogrenci1.Isim = "Ayse";
ogrenci1.SoyIsim = "Yilmaz";
ogrenci1.OgrenciNo = 375;
ogrenci1.Sinif = 5;

ogrenci1.OgrenciBilgileriniGetir();

ogrenci1.SinifAtlat();
ogrenci1.OgrenciBilgileriniGetir();


Ogrenci ogrenci2 = new Ogrenci("Oguz", "Ercan", 365, 1 );
ogrenci2.SinifDusur();
ogrenci2.OgrenciBilgileriniGetir();

class Ogrenci
{
    // properties/fields
    // diger siniflardan korunmak istenmekte, bu nedenle erisim belirteci private
    private string isim;
    private string soyIsim;
    private int ogrenciNo;
    private int sinif;

    // diger siniflardan korunmak istenmekle birlikte kontrollu bir bicimde de acmak istenmekte, bu nedenle ayni
        // fieldin benzer isimde public propertiesi olusturulur
    // get: ismi return eder - set: isme value atiyor (bunlar birer metot)
        // su sekilde de yazilabilirdi:
            // public string Isim
            // {
            //    // get {return isim;}
            //    // set {isim = value;} 
            // }  
    public string Isim { get => isim; set => isim = value; }
    public string SoyIsim { get => soyIsim; set => soyIsim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif 
    { 
        get => sinif; 
        set 
        {
            if (value < 1)
            {
                Console.WriteLine("Sınıf En Az 1 Olabilir!");
                sinif = 1;
            }
            else
            {
                sinif = value;
            }
        }
    }
    // kurucu olusturuluyor ve overload ediliyor (parametre alan ve almayan)
    public Ogrenci(string ısim, string soyIsim, int ogrenciNo, int sinif)
    {
        Isim = ısim;
        SoyIsim = soyIsim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }

    public Ogrenci(){}

    // ogrenci bilgilerini donduren vir metot olusturuluyor
    public void OgrenciBilgileriniGetir()
    {
        Console.WriteLine("***** Öğrenci Bilgileri *****");
        Console.WriteLine("Öğrencinin Adı           :{0}", this.Isim);
        Console.WriteLine("Öğrencinin Soyadı        :{0}", this.SoyIsim);
        Console.WriteLine("Öğrencinin Numarası      :{0}", this.OgrenciNo);
        Console.WriteLine("Ogrencinin Şubesi        :{0}", this.Sinif);
        // bu sinifin nesnesi yaratildiginda o nesne uzerindeki properties bilgisini alarak yazabilecek
    }

    // ogrencinin sinifinda degisiklik yapilabilecek bir yardimci metot
    public void SinifAtlat()
    {
        this.Sinif = this.Sinif + 1;
    }
    public void SinifDusur()
    {
        this.Sinif = this.Sinif - 1;
    }
}
    