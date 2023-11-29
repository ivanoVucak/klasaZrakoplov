using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaObjektVj1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov zrakoplov = new Zrakoplov();

            zrakoplov.setNaziv("Airbus");
            zrakoplov.setSnagaMotora(2000);
            zrakoplov.setDosegLeta(6000);

            Zrakoplov zrakoplov2 = new Zrakoplov ("Cessna Skycatcher", 75, 870);
            Zrakoplov zrakoplov3 = new Zrakoplov("Pilatus", 1200, 1333);


            Console.WriteLine(zrakoplov.ToString());
            Console.WriteLine(zrakoplov2.ToString());
            Console.WriteLine(zrakoplov3.ToString());


            Console.ReadKey();
        }
    }
}
