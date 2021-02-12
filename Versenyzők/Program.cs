using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versenyzők
{
    class Program
    {
        public static List<versenyzok> lista = new List<versenyzok>();
        static void Main(string[] args)
        {
            beolvas();
            /*foreach (var item in lista)
            {
                Console.WriteLine(item);
            }*/
            harmadikFeladat();
            negyedikFeladat();
            otodikFeladat();
            hatodikFeladat();
            hetedikFeladat();
            Console.ReadKey();
        }

        private static void hetedikFeladat()
        {
            List<int> rajtszamokLista = new List<int>();
            
            List<string> tobbszorEloforudoloRajtszamok = new List<string>();
            foreach (var item in lista)
            {
                if (item.Rajtszam != "")
                {
                    if (!rajtszamokLista.Contains(Convert.ToInt32(item.Rajtszam)))
                    {
                        rajtszamokLista.Add(Convert.ToInt32(item.Rajtszam));
                    }
                    else if (rajtszamokLista.Contains(Convert.ToInt32(item.Rajtszam)) && !tobbszorEloforudoloRajtszamok.Contains(item.Rajtszam))
                    {
                        tobbszorEloforudoloRajtszamok.Add(item.Rajtszam);
                    }
                }
            }
            Console.Write("7. Feladat: ");
            foreach (var item in tobbszorEloforudoloRajtszamok)
            {
                if (tobbszorEloforudoloRajtszamok[0] == item)
                {
                    Console.Write(item);
                }
                else
                {
                    Console.Write(", "+item);

                }
            }

            
        }

        private static void hatodikFeladat()
        {
            string legkisebbNemzetiseg = "";
            int legkisebbRajtszam = 0;
            foreach (var item in lista)
            {
                if (item.Rajtszam != "")
                {
                    legkisebbRajtszam = Convert.ToInt32(item.Rajtszam);
                    break;
                }
            }
            foreach (var item in lista)
            {
                if (item.Rajtszam != "")
                {
                    if (int.Parse(item.Rajtszam) < legkisebbRajtszam)
                    {
                        legkisebbNemzetiseg = item.Nemzetiseg;
                        legkisebbRajtszam = Convert.ToInt32(item.Rajtszam);
                    }
                }
            }
            Console.WriteLine("6. Feladat: " + legkisebbNemzetiseg);
        }

        private static void otodikFeladat()
        {
            Console.WriteLine("5. Feladat: ");
            foreach (var item in lista)
            {
                if (item.SzulDatum < new DateTime(1901,01,01))
                {

                    Console.WriteLine("\t"+item.Nev + " ("+ item.SzulDatum.ToString("yyyy. MM. dd.") + ")");
                }
            }
        }


        private static void negyedikFeladat()
        {
            Console.WriteLine("4. Feladat: "+lista[lista.Count-1].Nev);
        }

        private static void harmadikFeladat()
        {
            Console.WriteLine("3. Feladat: "+lista.Count);
        }

        private static void beolvas()
        {
            StreamReader sr = new StreamReader("pilotak.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] adatok = sor.Split(';');

                versenyzok vs = new versenyzok(adatok[0], DateTime.Parse(adatok[1]), adatok[2], adatok[3]);
                lista.Add(vs);
            }
            sr.Close();


        }
    }
}
