// See https://aka.ms/new-console-template for more information



Focus araba1 = new Focus();
Console.WriteLine(araba1.HangiMarkaninAraci().ToString());
Console.WriteLine(araba1.StandartRengiNe().ToString());
Console.WriteLine(araba1.KacTekerlegiVar());

Corolla araba2 = new Corolla();
Console.WriteLine(araba2.HangiMarkaninAraci().ToString());
Console.WriteLine(araba2.StandartRengiNe().ToString());
Console.WriteLine(araba2.KacTekerlegiVar());


// abstract class
Console.WriteLine("***** Abstract Class *****");

NewFocus araba3 = new NewFocus();
Console.WriteLine(araba3.HangiMarkaninAraci().ToString());
Console.WriteLine(araba3.StandartRengiNe().ToString());
Console.WriteLine(araba3.KacTekerlegiVar());

NewCorolla araba4 = new NewCorolla();
Console.WriteLine(araba4.HangiMarkaninAraci().ToString());
Console.WriteLine(araba4.StandartRengiNe().ToString());
Console.WriteLine(araba4.KacTekerlegiVar());