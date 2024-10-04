// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Kurs kurs1 = new Kurs();
kurs1.KursAdi = "C#";
kurs1.Egitmen = "EnginDemiroğ";
kurs1.IzlenmeOranı = 68;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Java";
kurs2.Egitmen = "Ali Veli";
kurs2.IzlenmeOranı = 45;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Python";
kurs3.Egitmen = "Hasan Yılmaz";
kurs3.IzlenmeOranı = 78;

Kurs[] kurslar = { kurs1 ,kurs2,kurs3};

foreach (var kurs in kurslar)
{
    Console.WriteLine("Kurs Adı: "+kurs.KursAdi);
}

class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOranı { get; set; }
}


