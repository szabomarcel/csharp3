﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    internal class FileInOut
    {
        // Osztályváltozók
        private string fileName;
        private FileMode fileMode;
        private FileAccess fileAccess;
        private FileStream fs;
        private StreamReader sr;

        // Konstructor
        public FileInOut()
        {
            setFilename(); // Fájl nevének bekérése
            setFileMode(); // MEgnyitás módjának bekérése
            setFileAccess(); // Hozzásférés módjánakbeállitása
        }

        private void setFilename()
        {
            Console.WriteLine("Adja meg a fájl nevét kiterjesztés nélkül: ");
            this.fileName = /* "..\\..\\" + */ Console.ReadLine() + "text";
        }
        private void setFileMode()
        {
            bool ismet;
            string s;

            Console.WriteLine("Adja meg a műveletet: "); // Létrehoz egy új fájl, ha már létezik, a tartalmát kitörli
            Console.WriteLine("     cr:  Create"); // Mint előbb, de ha már létezik a fájl, akkor kivételt dob
            Console.WriteLine("     crn: CreateNew"); //Megnyit egy fájlt, ha nem létezik, akkor kivételt dob
            Console.WriteLine("     o:   Open"); // Mint előbb, de ha nem létezik a fájl, akkor kivételt dob
            Console.WriteLine("     oc:  OpenOrCreate"); // Mint előbb, de ha nem létezik, akkor létrehozza a fájlt.
            Console.WriteLine("     a:   Append"); // Megnyit egy fájlt és automatikusan a végére áll. Ha nem létezik, létrehozza.
            Console.WriteLine("     t:   Truncate"); // Megnyit egy létező fájlt és törli a tartalmát.  Ebben a módban a fájl  tartalmát nem lehet olvasni (egyébként kivételt dob).
            do
            {
                ismet = false;
                s = Console.ReadLine();
                switch (s)
                {
                    case "cr": fileMode = FileMode.Create; break;
                    case "crn": fileMode = FileMode.CreateNew; break;
                    case "o": fileMode = FileMode.Open; break;
                    case "oc": fileMode = FileMode.OpenOrCreate; break;
                    case "a": fileMode = FileMode.Append; break;
                    case "t": fileMode = FileMode.Truncate; break;
                    default:
                        Console.WriteLine("Hibás adat! Ismételje meg!");
                        ismet = true;
                        break;
                }
            } while (ismet);
        }
        private void setFileAccess()
        {
            bool ismet;
            string s;

            Console.WriteLine("Adj meg a fájl hozzáférést: ");
            Console.WriteLine("     r:  Olvasás");
            Console.WriteLine("     w:  Írás");
            Console.WriteLine("     rw: Olvasás és írás");

            do
            {
                ismet = false;
                s = Console.ReadLine();
                switch (s)
                {
                    case "r": fileAccess = FileAccess.Read; break;
                    case "w": fileAccess = FileAccess.Write; break;
                    case "rw": fileAccess = FileAccess.ReadWrite; break;
                    default:
                        Console.WriteLine("Hibás adat! Ismételje meg!");
                        ismet = true; break;
                }
            } while (ismet);
        }
        /*
        string winDir = System.Environment.GetEnvironmentVariable("windir");
        public FileInOut(string fileName, FileMode fileMode, FileAccess fileAccess, FileStream fs, StreamReader sr, string winDir)
        {
            this.fileName = fileName;
            this.fileMode = fileMode;
            this.fileAccess = fileAccess;
            this.fs = fs;
            this.sr = sr;
            this.winDir = winDir;
        }
        public void enter(object sender, System.EventArgs e)
        {
            this.listBox1.Items.Clear();
            StreamReader reader = new StreamReader(winDir + "\\system.ini");
            try
            {
                do
                {
                    addListItem(reader.ReadLine());
                }
                while (reader.Peek() != -1);
            }
            catch
            {
                addListItem("File is empty");
            }
            finally
            {
                reader.Close();
            }
        }
        */
        public FileStream getFile()
        {
            return new FileStream(this.fileName, this.fileMode, this.fileAccess);
        }
        /*
        public StreamReader getFile2()
        {
            this.fs = new FileStream(this.fileName, this.fileMode, this.fileAccess);
            this.sr = new StreamReader(fs);
            return sr;
        }
        */
        public void closeFile()
        {
            if (this.sr != null) { this.sr.Close(); }
            if (this.fs != null) { this.fs.Close(); }
        }
    }
}
