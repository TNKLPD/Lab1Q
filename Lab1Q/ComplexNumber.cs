using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Q
{
    public class ComplexNumber
    {
        static int amount = 4;
        int a1, a2, a3, a4;
        int[] a = new int[4];
        int p = 1, fi = 1;


        public ComplexNumber(int a1, int a2, int a3, int a4)
        {
            this.a[0] = a1; this.a[1] = a2; this.a[2] = a3; this.a[3] = a4;
        }

        public void CompNum()
        {
            a[0] = a1;
            a[1] = a2;
            a[2] = a3;
            a[3] = a4;
            for (int i = 0; i < 4; i++)
            {
                a[i] = ((p+i) * i) * (2 ^ (fi * i));
            }
        }


        public override string ToString()
        {
            return $"{a1}\t{a2}\t{a3}\t{a4}";
        }

        //для себе
        /*
        private int[] a = new int[3];
        private int result;

        public ComplexNumber(int[]a)
        {
            this.a = a;
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = result;
            }
        }
        */

    }
}
