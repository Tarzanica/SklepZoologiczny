using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SklepZoologiczny
{
    public class DzialZeZwierzetami
    {
        public double cena;

        private string _nazwa;
        public string Opis { get; set; }

        public double Cena => cena;
        public string Nazwa => _nazwa;

        public DzialZeZwierzetami(string nazwa)
        {
            _nazwa = nazwa;
            cena = 0;
        }

        public void Wyswietl()
        {
            Console.WriteLine("Zwierzę: " + _nazwa);
            Console.WriteLine("Opis: " + Opis);
            Console.WriteLine("Cena: " + Cena + "zł");

        }
    }

    public class SklepZ
    {
        public void ConstructDzial(DzialBuilderZ dzialBuilder)
        {
            dzialBuilder.BuildOpis();
            dzialBuilder.BulidCena();
        }
    }
    public abstract class DzialBuilderZ
    {
        public DzialZeZwierzetami Dzialy { get; set; }
        public abstract void BuildOpis();
        public abstract void BulidCena();
    }
    public class Pies : DzialBuilderZ
    {
        public Pies()
        {
            Dzialy = new DzialZeZwierzetami("Pies");
        }

        public override void BuildOpis()
        {
            Dzialy.Opis = "Owczarek niemiecki";
        }

        public override void BulidCena()
        {
            Dzialy.cena = 2300;
        }

    }
    public class Kot : DzialBuilderZ
    {
        public Kot()
        {
            Dzialy = new DzialZeZwierzetami("Kot");
        }

        public override void BuildOpis()
        {
            Dzialy.Opis = "Kot perski";
        }

        public override void BulidCena()
        {
            Dzialy.cena = 2280;
        }

    }
    public class Chomik : DzialBuilderZ
    {
        public Chomik()
        {
            Dzialy = new DzialZeZwierzetami("Chomik");
        }

        public override void BuildOpis()
        {
            Dzialy.Opis = "Chomik syryjski";
        }

        public override void BulidCena()
        {
            Dzialy.cena = 34;
        }

    }
}
