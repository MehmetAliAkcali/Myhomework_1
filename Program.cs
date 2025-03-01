using System;

class Program
{
    static void Main(string[] args)
    {
        BMW bmw = new BMW();
        bmw.marka = "bmw";
        bmw.vites = "düz";

        Porsche porsche = new Porsche();
        porsche.marka = "Porsche";
        porsche.vites = "otomatik";

        Mercedes mercedes = new Mercedes();
        mercedes.marka = "Mercedes";
        mercedes.vites = "düz";

        Toyota toyota = new Toyota();
        toyota.marka = "Toyota";
        toyota.vites = "otomatik";

        Audi audi = new Audi();
        audi.marka = "Audi";
        audi.vites = "düz";


        bmw.VitesYazdir();
        porsche.VitesYazdir();
        mercedes.VitesYazdir();
        audi.VitesYazdir();
        toyota.VitesYazdir();
    }
}