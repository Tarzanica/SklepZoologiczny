using System;
using System.Collections.Generic;
using System.Text;

namespace SklepZoologiczny
{
    public interface ISklep
    {
        int Dzial { get; set; }
        void ZlozZamowienie(int dzial);
    }

    public class DzialZwierzeta : ISklep
    {
        public DzialZwierzeta()
        {
            this.Dzial = 1;
        }

        public int Dzial { get; set; }
        public void ZlozZamowienie(int dzial)
        {
            Dzial = dzial;
            Console.WriteLine("Dodawanie zwierzęcia do zamówienia...");
        }
    }

    public class DzialAkcesoria : ISklep
    {
        public DzialAkcesoria()
        {
            this.Dzial = 2;
        }
        public int Dzial { get; set; }

        public void ZlozZamowienie(int dzial)
        {
            Dzial = dzial;
            Console.WriteLine("Dodawanie akcesoria do zamówienia...");
        }
    }

    public class DzialKarma : ISklep
    {
        public DzialKarma()
        {
            this.Dzial = 3;
        }

        public int Dzial { get; set; }

        public void ZlozZamowienie(int dzial)
        {
            Dzial = dzial;
            Console.WriteLine("Dodawanie karmy do zamówienia...");
        }
    }


    public abstract class DzialAbstrakcyjny
    {
        private ISklep sklep;

        public DzialAbstrakcyjny(ISklep sklep)
        {
            this.sklep = sklep;
        }


        public void ZlozZamowienie(int dzial)
        {
            sklep.ZlozZamowienie(dzial);
        }

    }

    public class Zwierzeta : DzialAbstrakcyjny
    {
        public Zwierzeta(ISklep sklep) : base(sklep)
        {

        }

        public void DoZlozZamowienie()
        {

            ZlozZamowienie(1);
        }
    }

    public class Akcesoria : DzialAbstrakcyjny
    {
        public Akcesoria(ISklep sklep) : base(sklep)
        {

        }

        public void DoZlozZamowienie()
        {

            ZlozZamowienie(2);
        }
    }

    public class Karma : DzialAbstrakcyjny
    {
        public Karma(ISklep sklep) : base(sklep)
        {

        }

        public void DoZlozZamowienie()
        {

            ZlozZamowienie(3);
        }
    }
}
