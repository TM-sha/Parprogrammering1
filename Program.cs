using System.Threading.Channels;

namespace Parprogrammering1
{
    internal class Program
    {
        static void Main()
        {
            do
            {
                Console.WriteLine("Skriv inn tekst => Enter");
                Console.WriteLine();


                string vanligTekst, reversertTekst = "";
                int number;



                vanligTekst = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Manipulèr tekst:\n" +
                                  "Store bokstaver    --> Tast: 1\n" +
                                  "Små bokstaver      --> Tast: 2\n" +
                                  "Reversèr tekst     --> Tast: 3\n" +
                                  "Reversèr tekst + 1 --> Tast: 4\n" +
                                  "Reversèr tekst + 2 --> Tast: 5\n" +
                                  "Bonus: e'er = a'er --> Tast: 6\n" +
                                  "Avslutt programmet --> Tast: 7");
                Console.WriteLine();
                Console.Write("Ditt valg: ");

                number = vanligTekst.Length - 1;


                while (number >= 0)
                {
                    reversertTekst += vanligTekst[number];
                    number--;
                }


                var bokstavValg = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Resultat: ");
                switch (bokstavValg)
                {
                    case "1":
                        Console.WriteLine(vanligTekst.ToUpper());
                        Console.WriteLine();
                        break;

                    case "2":
                        Console.WriteLine(vanligTekst.ToLower());
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine(reversertTekst);
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine(reversertTekst.ToUpper());
                        Console.WriteLine();
                        break;
                    case "5":
                        Console.WriteLine(reversertTekst.ToLower());
                        Console.WriteLine();
                        break;
                    case "6":
                        Console.WriteLine(vanligTekst.Replace('e', 'a'));
                        break;
                    case "7":
                        Console.WriteLine("Programmet avsluttes. .");
                        Environment.Exit(1);
                        break;
                }


            } while (true);
        }
    }
}






