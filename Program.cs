using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje4
{
    class Biljka
    {

    }
    class Stablo:Biljka
    {
        bool opadajuListovi;

        public Stablo(bool opadajuListovi)
        {
            this.opadajuListovi = opadajuListovi;
        }

        public bool OpadajuListovi { get => opadajuListovi; set => opadajuListovi = value; }

    }
    class Cvijet:Biljka
    {

    }
    class Bijelogoricno : Stablo
    {
        public Bijelogoricno(bool opadajuListovi) : base(opadajuListovi)
        {
        }
    }
    class Crnogoricno : Stablo
    {
        public Crnogoricno(bool opadajuListovi) : base(opadajuListovi)
        {
        }
    }


    /*
     * Definirajte klasu Biljka, te definirajte od nje izvedenu klasu Stablo sa sljedećim članicama:
• varijabla tipa bool opadajuListovi
• svojstvo OpadajuListovi
• konstruktor Stablo(bool) koji će dodijeliti vrijednost proslijeđenog argumenta varijabli
opadajuListovi
Definirajte klasu Cvijet izvedenu iz klase Biljka.
Definirajte klase Bijelogoricno i Crnogoricno izvedene iz klase Stablo.
Klasama definirajte odgovarajuće konstruktore.
Definirajte dva objekta Hrast i Bor tipova Bijelogoricno i Crnogoricno, te ispišite vrijednosti
njihovih članica opadajuListovi.

     * */
    internal class Program
    {
        static void Main(string[] args)
        {
            Bijelogoricno Hrast = new Bijelogoricno(true);

            Crnogoricno Bor = new Crnogoricno(false);
            Console.WriteLine(Hrast.OpadajuListovi);
            Console.WriteLine(Bor.OpadajuListovi);
            Console.ReadKey();
        }
    }
}
