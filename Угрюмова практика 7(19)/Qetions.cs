using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Угрюмова_практика_7_19_
{
    internal class Qetions
    {
        public string[,] qetions;
        public int curr_numb = 0; 
        public double answer = 0;
        public int longQetions;
        public int LengthTest()
        {
            StreamReader sr2 = new StreamReader("test.txt");
            int a = File.ReadAllLines("test.txt").Count();
            a = a / 11;
            sr2.Close();
            return a;
        }
    }
}
