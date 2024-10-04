// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


#region Degiskenler
double dolarDun = 45.1;
double dolarBugun = 14.6;
#endregion


#region Diziler

string kurs1 = "c# kursu";
string kurs2 = "java Kursu";
string kurs3 = "python";

String[] kurslar2 = new string[2]; 

String[] kurslar = {kurs1,kurs2,kurs3};

for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine("Kurs :"+kurslar[i]);
}

#endregion