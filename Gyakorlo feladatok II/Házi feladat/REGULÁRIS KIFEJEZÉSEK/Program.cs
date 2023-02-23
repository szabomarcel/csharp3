using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGULÁRIS_KIFEJEZÉSEK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex("^[1-9][0-9]*");
            string s1 = "012345"; // 1.szöveg egyenlő a 0-5-ig halladó számmal kiíratás
            string s2 = "112345";// 2.szöveg egyenlő a számmal kiíratás
            string s3 = "2";// 3.szöveg egyenlő a 2 számú számmal kiíratás
            Console.WriteLine("{0} : {1}", s1, (pattern.IsMatch(s1) ?
            "természetes szám" : "nem természetes szám"));// 1.szöveg kiíratás

            Console.WriteLine("{0} : {1}", s2, (pattern.IsMatch(s2) ?
            "természetes szám" : "nem természetes szám"));// 2.szöveg kiíratás

            Console.WriteLine("{0} : {1}", s3, (pattern.IsMatch(s3) ?
            "természetes szám" : "nem természetes szám"));// 3.szöveg kiíratás

            Console.ReadKey();
        }
    }
}
