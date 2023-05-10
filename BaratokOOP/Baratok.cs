using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaratokOOP
{
    internal class Baratok
    {
        // Konstruktor
        struct barat
        {
            public string nev;
            public int eletkor;
        }
        //  Adatok beolvasása fájlból vagy generálása a programban, majd elhelyezése listában.
        StreamWriter f = new StreamWriter(@"C:\Users\Lenovo\Source\Repos\csharp\BaratokOOP\bin\Debug\fajlnev");
        List<int> list = new List<int>();
        // Új barát felvétele a listába

        
        // Barát törlése a listából név alapján
       

        // Annak ellenőrzése, hogy egy személy szerepel-e a listában
        

        // Lista kiíratása fájlba.A fájl neve: baratok.csv


        // 1.-B Barátok osztály bővítése
        // Táblázatba kiíratja a szülő osztályt + bővítés



        /*
        * 1.-C Barátok osztály bővítése
        * Lapozás előre-hátra képernyőnként 20 rekord kiírással kalkulálva!
        * A lapozást a PageUp és PageDown gombokkal lehessen megvalósítani!
        * Ezenfelül a Home billentyűvel lehessen az első, az End billentyűvel az utolsó lapra ugorni!
        */
        
        
        
        /*
        * 1.-D Barátok osztály bővítése
        * A szülő osztályt új metódussal bővítjük, amely a lista alapján határozza meg,
        * hogy van-e elég olyan barátunk, akikkel egy születésnapi bulit tudunk összehozni!
        * Ehhez olyan barátokra van szükségünk, akik életkora hasonló a miénkhez(+/- 3 év) és bulizási hajlama legalább 5-ös skálaértékű.A buli minimális létszáma 10 fő.
        * Amennyiben van elég barátunk, írjuk ki a neveiket a buli.csv fájlba!
        */



    }
}
