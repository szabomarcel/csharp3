﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOOP
{
    internal class Matrix
    {
        // Konstruktor
        public int sor = 0;
        public int oszlop = 0;
        public static Random rnd = new Random();
        public Matrix() { }
        public Matrix(int sor, int ostlop, int rnd)
        {
            this.sor = sor;
            this.oszlop = ostlop;   
        }
        // Matrix elemeinek beállitása
        // Matrix kiírása a konzolra
        private static void MatrixKiirat(int[,] kiirando_matrix)
        {
            for (int i = 0; i < kiirando_matrix.GetLength(0); i++)
            {
                for (int j = 0; j < kiirando_matrix.GetLength(1); j++)
                {
                    Console.WriteLine("{0}\t", kiirando_matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        // Determináns meghatározásas
        // Determináns lekérése // Bal felső sarokból átlósan kiszámolni a jobb sarok átlójával.
        // Függvényként való hasznát
        static int[,] RandomMatrixLetrehoz(int sor, int oszlop)
        {
            int[,] matrix_fuggvennnyel = new int[sor, oszlop];
            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < oszlop; j++)
                {
                    matrix_fuggvennnyel[i, j] = rnd.Next(1, 20);
                }
            }
            return matrix_fuggvennnyel;
        }
        
        
    }
}
