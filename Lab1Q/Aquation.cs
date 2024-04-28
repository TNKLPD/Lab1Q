using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Q
{
    public class Aquation
    {
        static int t = 1;

        public void Aquations()
        {
            t = 3;
        }

        public override string ToString()
        {
            return $"{t}";
        }


        //для себе
        /*
        int j;
        int k;
        int jk;
        public Aquation(int a1, int a2, int a3, int a4) : base(a1, a2, a3, a4)
        {
            k = a1;
        }
        public void Aquations()
        {
            j = 1;
            jk = j + k;
            
        }
        public override string ToString() 
        {
            return $"{j}\t{k}\t{jk}";
        }
        int k = 10;
        public Aquation(int[] a) : base(a)
        {
            a[0] = k;
        }
        public void Aquations()
        {
            int j = 1 + 1;
        }
        */

    }
}
