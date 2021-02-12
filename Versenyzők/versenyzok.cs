using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versenyzők
{
    class versenyzok
    {
        private string nev;
        private DateTime szulDatum;
        private string nemzetiseg;
        private string rajtszam;

        public versenyzok(string nev, DateTime szulDatum, string nemzetiseg, string rajtszam)
        {
            this.nev = nev;
            this.szulDatum = szulDatum;
            this.nemzetiseg = nemzetiseg;
            this.rajtszam = rajtszam;
        }

        public string Nev { get => nev; set => nev = value; }
        public DateTime SzulDatum { get => szulDatum; set => szulDatum = value; }
        public string Nemzetiseg { get => nemzetiseg; set => nemzetiseg = value; }
        public string Rajtszam { get => rajtszam; set => rajtszam = value; }

        public override string ToString()
        {
            return nev + '\t' + szulDatum +'\t' + nemzetiseg +'\t' + rajtszam;
        }
    }
}
