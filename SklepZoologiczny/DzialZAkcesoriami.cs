using System;
using System.Collections.Generic;
using System.Text;

namespace SklepZoologiczny
{
    public class DzialZAkcesoriami
    {
        private string _nazwa;
        public double cena;
        public string Opis { get; set; }

        public double Cena => cena;
        public string Nazwa => _nazwa;

        public DzialZAkcesoriami(string nazwa)
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

    public class SklepA
    {
        public void ConstructDzial(DzialBuilderA dzialBuilder)
        {
            dzialBuilder.BuildOpis();
            dzialBuilder.BulidCena();
        }
    }
    public abstract class DzialBuilderA
    {
        public DzialZAkcesoriami Dzialy { get; set; }
        public abstract void BuildOpis();
        public abstract void BulidCena();
    }
    public class Smycz : DzialBuilderA
    {
        public Smycz()
        {
            Dzialy = new DzialZAkcesoriami("Smycz");
        }

        public override void BuildOpis()
        {
            Dzialy.Opis = "rozmiar M, 5m";
        }

        public override void BulidCena()
        {
            Dzialy.cena = 56.90;
        }

    }
    public class Klatka : DzialBuilderA
    {
        public Klatka()
        {
            Dzialy = new DzialZAkcesoriami("Klatka");
        }

        public override void BuildOpis()
        {
            Dzialy.Opis = "wymiary: 410x270x405 mm";
        }

        public override void BulidCena()
        {
            Dzialy.cena = 129.99;
        }

    }
    public class Kuweta : DzialBuilderA
    {
        public Kuweta()
        {
            Dzialy = new DzialZAkcesoriami("Kuweta");
        }

        public override void BuildOpis()
        {
            Dzialy.Opis = "Kuweta dla kota";
        }

        public override void BulidCena()
        {
            Dzialy.cena = 119;
        }

    }
}
