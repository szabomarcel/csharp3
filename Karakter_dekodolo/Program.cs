﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http.Headers;

namespace Karakter_dekodolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string karakter ; string matrix = "";
            string[] beolvas = File.ReadAllLines("bank.txt");
            List<Karakter> adatok = new List<Karakter>();
            for (int i = 0; i < beolvas.Length; i+=8)
            {
                karakter = beolvas[i];
                for (int j = 1; j < 8; j++)
                {
                    matrix += beolvas[i + j];
                }
                Karakter resz = new Karakter(karakter, matrix);
                adatok.Add(resz);
                matrix = "";
            }
            Console.WriteLine($"Karakterek száma: {adatok.Count}");

            foreach(Karakter resz in adatok)
            {
                Console.WriteLine(resz.karakter + " " + resz.matrix);
            }
            Console.WriteLine("6. feladat");
            List<string> abc = new List<string>();
            for (char i = 'A'; i <= 'Z' ; i++)
            {
                abc.Add(i.ToString());
            }
            string be = "";

            while (!abc.Contains(be))
            {
                Console.WriteLine("Adj meg egy angol nagybetűt: ");
                be = Console.ReadLine();
            }
            Console.WriteLine("7.Feladat");
            bool van = false;
            foreach (var i in adatok)
            {
                if(be == i.karakter)
                {
                    Karakter.kiir(i);
                    van = true;
                }
            }
            if(!van)
            {
                Console.WriteLine("Nincs ilyen karakter!");
            }

            string[] ujbeolvas = File.ReadAllLines("dekodol.txt");
            List<Karakter> ujadatok = new List<Karakter>();
            for (int i = 0; i < ujbeolvas.Length; i += 8)
            {
                karakter = ujbeolvas[i];
                for (int j = 1; j < 8; j++)
                {
                    matrix += ujbeolvas[i + j];
                }
                Karakter resz = new Karakter(karakter, matrix);
                ujadatok.Add(resz);
                matrix = "";
            }

            string titok = "";
            bool ismert = false;
            for (int i = 0; i < ujadatok.Count; i++)
            {
                for (int j = 0; j < adatok.Count; j++)
                {
                    if (Karakter.Felismer(adatok[j], ujadatok[i]))
                    {
                        ismert = true;
                        titok += adatok[j];
                    }
                    if (!ismert)
                    {
                        titok += "?";
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
