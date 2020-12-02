using System;
using System.Collections.Generic;
using System.Text;

namespace SklepZoologiczny
{
    public class DzialZKarma
    {
        private string _nazwa;
        public double cena;
        public string Opis { get; set; }
        public string Nazwa => _nazwa;

        public double Cena => cena;

        public DzialZKarma(string nazwa)
        {
            _nazwa = nazwa;
            cena = 0;
        }

        public void Wyswietl()
        {
            Console.WriteLine("Produkt: " + _nazwa);
            Console.WriteLine("Opis: " + Opis);
            Console.WriteLine("Cena: " + Cena + "zł");

        }
    }

    public class SklepK
    {
        public void ConstructDzial(DzialBuilderK dzialBuilder)
        {
            dzialBuilder.BuildOpis();
            dzialBuilder.BulidCena();
        }
    }
    public abstract class DzialBuilderK
    {
        public DzialZKarma Dzialy { get; set; }
        public abstract void BuildOpis();
        public abstract void BulidCena();
    }
    public class PiesK : DzialBuilderK
    {
        public PiesK()
        {
            Dzialy = new DzialZKarma("Royal Canin Medium Adult");
        }

        public override void BuildOpis()
        {
            Dzialy.Opis = "2 x 40 kg";
        }

        public override void BulidCena()
        {
            Dzialy.cena = 323.40;
        }

    }
    public class KotK : DzialBuilderK
    {
        public KotK()
        {
            Dzialy = new DzialZKarma("Royal Canin Kitten");
        }

        public override void BuildOpis()
        {
            Dzialy.Opis = "2x 10kg";
        }

        public override void BulidCena()
        {
            Dzialy.cena = 386.40;
        }

    }
    public class ChomikK : DzialBuilderK
    {
        public ChomikK()
        {
            Dzialy = new DzialZKarma("Versele Laga Nature");
        }

        public override void BuildOpis()
        {
            Dzialy.Opis = "700g mieszanka zbożowa";
        }

        public override void BulidCena()
        {
            Dzialy.cena = 17.50;
        }

    }
}

