using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace helysegMgyrrszg
{
    internal class Program
    {
        #region Egész fálj olvasása
        private static void fileReadFull(FileStream file)
        {
            using (StreamReader sr = new StreamReader(file))
            {
                // Dolgozzunk a fájllal
                // Egészet kiolvassa

                Console.WriteLine("Egyserre olvassa a fájlt!");

                string s = sr.ReadToEnd();
                Console.WriteLine(s);
                Console.WriteLine(); // Emelünk egy üres sort
            }
        }
        #endregion Egész fálj olvasása

        static void Main(string[] args)
        {
            helysegMgyrrszg f = new helysegMgyrrszg();
            fileReadFull(f.getFile());
            fileReadLine(f.getFile());
            string[] s = { "C# Label Control", "C# Button Control", "C# TextBox Control", "C# ComboBox", "C# ListBox Control", "C# Checked ListBox Control", "C# CheckBox Control", "C# PictureBox Control", "C# ProgressBar Control", "C# ScrollBars Control", "C# DateTimePicker Control", "C# Treeview Control", "C# ListView Control", "C# Menu Control", "C# MDI Form", "C# Color Dialog Box", "C# Font Dialog Box", "C# OpenFile Dialog Box", "C# Print Dialog Box" };
            fileWrite(f.getFile(), s);
            Console.ReadKey();
        }
        #region Soronlénti olvasás
        private static void fileReadLine(FileStream file)
        {
            using (StreamReader sr = new StreamReader(file))
            {
                // Dogozunk a fájlal
                Console.WriteLine("Soronként olvassa a fájlt");
                // Soronként olvas
                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    Console.WriteLine(s);
                }
            }
        }
        #endregion Soronlénti olvasás

        #region File írás
        private static void fileWrite(FileStream file, string[] s)
        {
            using (StreamWriter sr = new StreamWriter(file))
            {
                // Dogozunk a fájlal
                Console.WriteLine("Írja a fájlt");
                // Soronként olvas
                for (int i = 0; i < s.Length; i++)
                {
                    sr.WriteLine(s[i]);
                    Console.WriteLine(s); //Kiírás ellenőrzése
                }
            }
        }
        #endregion File írás
    }
}
