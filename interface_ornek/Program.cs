// See https://aka.ms/new-console-template for more information



// bu sekilde interface kullanilarak ortak olan ozellikleri interface uzerinde toplayip classlari da ondan kalitim alinarak sinifin cercevesi belirlenir

Focus araba1 = new Focus();
Console.WriteLine(araba1.HangiMarkaninAraci().ToString());
Console.WriteLine(araba1.StandartRengiNe().ToString());
Console.WriteLine(araba1.KacTekerlegiVar());

Corolla araba2 = new Corolla();
Console.WriteLine(araba2.HangiMarkaninAraci().ToString());
Console.WriteLine(araba2.StandartRengiNe().ToString());
Console.WriteLine(araba2.KacTekerlegiVar());
