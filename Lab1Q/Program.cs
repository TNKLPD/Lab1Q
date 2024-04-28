using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Q
{
    public class Program
    {
        static void Main(string[] args)
        {
            Output output = new Output();
            Aquation aquation = new Aquation();
            ComplexNumber complexNumber = new ComplexNumber(1,2,3,4);

            complexNumber.CompNum();
            output.OutputValue();
            Console.ReadLine();

            /*
            ComplexNumber complexNumber = new ComplexNumber(1,2,3,4);
            complexNumber.CompNum();
            Console.WriteLine(complexNumber);
            Console.ReadLine();
            */

            //для себе
            /*
             ComplexNumber complexNumber;

            Aquation j = new Aquation(1,2,3,4);
            j.Aquations();
            Console.WriteLine(j);

            Console.ReadLine();
            */
        }
    }
}
