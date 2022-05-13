// See https://aka.ms/new-console-template for more information



TohumluBitkiler tohumluBitki = new TohumluBitkiler();
tohumluBitki.Beslenme();
tohumluBitki.Bosaltim();
tohumluBitki.Solunum();
// tohumluBitki.FotosentezYapmak();
tohumluBitki.TohumlaCogalma();

Console.WriteLine("**********************");

Ordek ordek = new Ordek();
ordek.Solunum();
ordek.Beslenme();
ordek.Bosaltim();
// ordek.SuruHalindeHareket();
ordek.Yuzmek(); 



// Erisim belirtecleri public yapilmisti. Bu  cok dogru bir yontem degil. temel siniflara sadece kendisinden kalitim alan siniflar tarafindan erisilmesi istendiginden protected erisim belirteci kullanilmali (Bitkiler sinifinin FotosentezYapmak metodu protected yapildi ve erisim gerceklesmedi)