using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaObjektVj1
{
    internal class Zrakoplov
    {
        string naziv;
        int snagaMotora, dosegLeta;


            public void setNaziv(string naziv)
        {
            this.naziv = naziv;
        }
        public string GetNaziv()
        {
            return this.naziv;
        }

        public void setSnagaMotora(int snagaMotora)
        {
            this.snagaMotora = snagaMotora;
        }
        public int GetSnagaMotora()
        {
            return this.snagaMotora;
        }

        public void setDosegLeta(int dosegLeta)
        {
            this.dosegLeta = dosegLeta;
        }
        public int GetDosegLeta()
        {
            return this.dosegLeta;
        }


        public override string ToString()
        {
            string ispis = "Naziv: " + this.GetNaziv() + "\n"
                + "Snaga Motora: " + this.GetSnagaMotora() + "kW\n"
                + "Doseg leta: " + this.GetDosegLeta() + "km\n";
            return ispis;
        }

     

        public Zrakoplov(String naziv, int SnagaMotora,
            int dosegLeta)
        {
            this.naziv = naziv;
            this.snagaMotora = SnagaMotora;
            this.dosegLeta = dosegLeta;
        }
        public Zrakoplov() { }
    }
}
