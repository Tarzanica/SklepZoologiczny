using System;

namespace SklepZoologiczny
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Witaj w naszym sklepie!");
            Console.WriteLine("Czy chcesz coś zamówić? TAK/NIE");
            string opcja =  Console.ReadLine().ToLower();

            if (opcja == "tak")
            {
                Console.WriteLine("Wybierz dział: 1 - Dział ze zwierzętami, 2 - Dział z akcesoriami, 3 - Dział z karmą");
            }
            else if (opcja == "nie")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Wpisz słowo \"tak\" lub \"nie\"");
                opcja = Console.ReadLine();
            }

            int wybor = Int32.Parse(Console.ReadLine());

            switch (wybor)
            {
                case 1:

                    Console.WriteLine("---------------- Dział ze zwierzętami -----------------");

                    SklepZ sklep = new SklepZ();

                    DzialBuilderZ dzialBuilder = new Pies();
                    sklep.ConstructDzial(dzialBuilder);
                    dzialBuilder.Dzialy.Wyswietl();
                    Console.WriteLine();

                    DzialBuilderZ dzialBuilder2 = new Kot();
                    sklep.ConstructDzial(dzialBuilder2);
                    dzialBuilder2.Dzialy.Wyswietl();
                    Console.WriteLine();

                    DzialBuilderZ dzialBuilder3 = new Chomik();
                    sklep.ConstructDzial(dzialBuilder3);
                    dzialBuilder3.Dzialy.Wyswietl();
                    Console.WriteLine();

                    //Console.WriteLine("Wybierz zwierzę, podając numer od 1 - 3:");
                    //int opcjaZ = Int32.Parse(Console.ReadLine());

                    //switch (opcjaZ)
                    //{
                    //    case 1:

                    //    default:
                    //        break;
                    //}

                    break;

                case 2:

                    Console.WriteLine("----------------- Dział z akcesoriami ------------------");
                    SklepA sklepA = new SklepA();

                    DzialBuilderA dzialBuilderA = new Smycz();
                    sklepA.ConstructDzial(dzialBuilderA);
                    dzialBuilderA.Dzialy.Wyswietl();
                    Console.WriteLine();

                    DzialBuilderA dzialBuilderA2 = new Klatka();
                    sklepA.ConstructDzial(dzialBuilderA2);
                    dzialBuilderA2.Dzialy.Wyswietl();
                    Console.WriteLine();

                    DzialBuilderA dzialBuilderA3 = new Kuweta();
                    sklepA.ConstructDzial(dzialBuilderA3);
                    dzialBuilderA3.Dzialy.Wyswietl();
                    Console.WriteLine();

                    Console.WriteLine("Wybierz akcesoria, podając numer od 1 - 3:");
                    int opcjaA = Int32.Parse(Console.ReadLine());

                    break;

                case 3:


                    Console.WriteLine("------------------- Dział z karmą ----------------------");
                    SklepK sklepK = new SklepK();

                    DzialBuilderK dzialBuilderK = new PiesK();
                    sklepK.ConstructDzial(dzialBuilderK);
                    dzialBuilderK.Dzialy.Wyswietl();
                    Console.WriteLine();

                    DzialBuilderK dzialBuilderK2 = new KotK();
                    sklepK.ConstructDzial(dzialBuilderK2);
                    dzialBuilderK2.Dzialy.Wyswietl();
                    Console.WriteLine();

                    DzialBuilderK dzialBuilderK3 = new ChomikK();
                    sklepK.ConstructDzial(dzialBuilderK3);
                    dzialBuilderK3.Dzialy.Wyswietl();
                    Console.WriteLine();
                    break;

                default:
                    break;
            }

            

           

        }
    }
}
