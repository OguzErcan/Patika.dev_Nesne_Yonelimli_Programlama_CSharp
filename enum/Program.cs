// See https://aka.ms/new-console-template for more information



Console.WriteLine("***** Ardisik Degerleri Tutmak Icın *****");

Console.WriteLine(Gunler.Pazar);
Console.WriteLine((int)Gunler.Cumartesi);


Console.WriteLine("***** Sabit Degerleri Tutmak Icın *****");

int sicaklik = 32;

if (sicaklik <= (int)HavaDurumu.Normal)
{
    Console.WriteLine("Disariya cikmak icin havanin biraz daha isinmasini bekleyelim.");
}
else if (sicaklik >= (int)HavaDurumu.Sicak)
{
    Console.WriteLine("Disariya cikmak icin cok sicak bir gun.");
}
else if (sicaklik >= (int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.CokSicak)
{
    Console.WriteLine("hadi disariya cikalim");
}



enum Gunler
{
    Pazartesi = 1,
    Sali,
    Carsamba,
    Persembe,
    Cuma,
    Cumartesi,
    Pazar
}
// numerik veriyi daha anlamli bir sekilde tutmayi sagladi
// cumaya 13 degerini verirsek cumaya kadar 1 i takip eder cumadan sonra 13 degerini



enum HavaDurumu
{
    Soguk = 5,
    Normal = 20,
    Sicak = 25,
    CokSicak = 30
}