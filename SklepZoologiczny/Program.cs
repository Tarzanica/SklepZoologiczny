using System;
using System.Collections.Generic;

namespace SklepZoologiczny
{
    class Program
    {
        static void Main(string[] args)
        {
            double cena;
            double rachunekSuma = 0;
            int iloscProduktu = 1;
            List<string> listaProduktow = new List<string>();
            ISklep iSklepZ = new DzialZwierzeta();
            ISklep iSklepA = new DzialAkcesoria();
            ISklep iSklepK = new DzialKarma();

            Zwierzeta zwierzeta = new Zwierzeta(iSklepZ);
            Akcesoria akcesoria = new Akcesoria(iSklepA);
            Karma karma = new Karma(iSklepK);

            Console.WriteLine("Witaj w naszym sklepie!");
            Console.WriteLine("Czy chcesz coś zamówić? TAK/NIE");



            string opcja = Console.ReadLine().ToLower();
            do
            {
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
                    Console.WriteLine("Wybierz dział: 1 - Dział ze zwierzętami, 2 - Dział z akcesoriami, 3 - Dział z karmą");
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

                        Console.WriteLine("Wybierz zwierzę, podając numer od 1 - 3:");
                        int opcjaZ = Int32.Parse(Console.ReadLine());

                        switch (opcjaZ)
                        {
                            case 1:
                                Console.Write("Podaj ilość: ");
                                iloscProduktu = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Wybrano: owczarek niemiecki");
                                Console.WriteLine($"Ilość: {iloscProduktu}");

                                dzialBuilder.BulidCena();
                                cena = dzialBuilder.Dzialy.cena * iloscProduktu;
                                rachunekSuma += cena;
                                listaProduktow.Add(dzialBuilder.Dzialy.Nazwa + $" - ilość: {iloscProduktu}");
                                break;
                            case 2:
                                Console.Write("Podaj ilość: ");
                                iloscProduktu = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Wybrano: kot perski");
                                Console.WriteLine($"Ilość: {iloscProduktu}");

                                dzialBuilder2.BulidCena();
                                cena = dzialBuilder2.Dzialy.cena * iloscProduktu;
                                rachunekSuma += cena;
                                listaProduktow.Add(dzialBuilder2.Dzialy.Nazwa + $" - ilość: {iloscProduktu}");
                                break;
                            case 3:
                                Console.Write("Podaj ilość: ");
                                iloscProduktu = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Wybrano: chomik syryjski");
                                Console.WriteLine($"Ilość: {iloscProduktu}");

                                dzialBuilder3.BulidCena();
                                cena = dzialBuilder3.Dzialy.cena * iloscProduktu;
                                rachunekSuma += cena;
                                listaProduktow.Add(dzialBuilder3.Dzialy.Nazwa + $" - ilość: {iloscProduktu}");
                                break;
                            default:

                                break;
                        }

                        
                        zwierzeta.DoZlozZamowienie();
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

                        switch (opcjaA)
                        {
                            case 1:
                                Console.Write("Podaj ilość: ");
                                iloscProduktu = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Wybrano: smycz");
                                Console.WriteLine($"Ilość: {iloscProduktu}");

                                dzialBuilderA.BulidCena();
                                cena = dzialBuilderA.Dzialy.cena * iloscProduktu;
                                rachunekSuma += cena;
                                listaProduktow.Add(dzialBuilderA.Dzialy.Nazwa + $" - ilość: {iloscProduktu}");
                                break;
                            case 2:
                                Console.Write("Podaj ilość: ");
                                iloscProduktu = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Wybrano: klatka");
                                Console.WriteLine($"Ilość: {iloscProduktu}");

                                dzialBuilderA2.BulidCena();
                                cena = dzialBuilderA2.Dzialy.cena * iloscProduktu;
                                rachunekSuma += cena;
                                listaProduktow.Add(dzialBuilderA2.Dzialy.Nazwa + $" - ilość: {iloscProduktu}");
                                break;
                            case 3:
                                Console.Write("Podaj ilość: ");
                                iloscProduktu = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Wybrano: kuweta");
                                Console.WriteLine($"Ilość: {iloscProduktu}");

                                dzialBuilderA3.BulidCena();
                                cena = dzialBuilderA3.Dzialy.cena * iloscProduktu;
                                rachunekSuma += cena;
                                listaProduktow.Add(dzialBuilderA3.Dzialy.Nazwa + $" - ilość: {iloscProduktu}");
                                break;
                            default:
                                break;
                        }
                        akcesoria.DoZlozZamowienie();
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

                        Console.WriteLine("Wybierz akcesoria, podając numer od 1 - 3:");
                        int opcjaK = Int32.Parse(Console.ReadLine());

                        switch (opcjaK)
                        {
                            case 1:
                                Console.Write("Podaj ilość: ");
                                iloscProduktu = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Wybrano: Royal Canin Medium Adult");
                                Console.WriteLine($"Ilość: {iloscProduktu}");

                                dzialBuilderK.BulidCena();
                                cena = dzialBuilderK.Dzialy.cena * iloscProduktu;
                                rachunekSuma += cena;
                                listaProduktow.Add(dzialBuilderK.Dzialy.Nazwa + $" - ilość: {iloscProduktu}");
                                break;
                            case 2:
                                Console.Write("Podaj ilość: ");
                                iloscProduktu = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Wybrano: Royal Canin Kitten");
                                Console.WriteLine($"Ilość: {iloscProduktu}");

                                dzialBuilderK2.BulidCena();
                                cena = dzialBuilderK2.Dzialy.cena * iloscProduktu;
                                rachunekSuma += cena;
                                listaProduktow.Add(dzialBuilderK2.Dzialy.Nazwa + $" - ilość: {iloscProduktu}");
                                break;
                            case 3:
                                Console.Write("Podaj ilość: ");
                                iloscProduktu = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Wybrano: Versele Laga Nature");
                                Console.WriteLine($"Ilość: {iloscProduktu}");

                                dzialBuilderK3.BulidCena();
                                cena = dzialBuilderK3.Dzialy.cena * iloscProduktu;
                                rachunekSuma += cena;
                                listaProduktow.Add(dzialBuilderK3.Dzialy.Nazwa + $" - ilość: {iloscProduktu}");
                                break;
                            default:
                                break;
                        }
                        karma.DoZlozZamowienie();
                        break;

                    default:
                        break;
                }

                Console.WriteLine("Czy kontynujesz zakupy? (TAK/NIE)");
                opcja = Console.ReadLine().ToLower();

            } while (opcja == "tak");

            Console.WriteLine("========================RACHUNEK==============================");

            Console.WriteLine("Zakupileś: ");
            Console.WriteLine();
            foreach (var item in listaProduktow)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("===================Twój rachunek wynosi=====================");
            Console.WriteLine(rachunekSuma);
        }
    }
}
