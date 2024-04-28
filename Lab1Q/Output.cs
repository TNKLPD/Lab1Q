using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Q
{
    public class Output //class for console output
    {
        ComplexNumber k = new ComplexNumber(1, 2, 3, 4);    //k temporarry value
        Aquation aquations = new Aquation();
        public async void OutputValue()
        {
            aquations.Aquations();
            k.CompNum();    //call complex numbers method
            Console.WriteLine(k + "\t" + aquations);
        }

    }
}
