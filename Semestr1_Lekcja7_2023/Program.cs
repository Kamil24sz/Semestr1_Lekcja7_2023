using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr1_Lekcja7_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w naszym sklepie!");
            Console.WriteLine("Wybierz produkt, który Cię interesuje");
            Console.WriteLine("1.Klawiatura podświetlana Logitech");
            Console.WriteLine("2.Mysz gamingowa Razer");
            Console.WriteLine("3.Obudowa komputerowa podświetlana SilentiumPC");

            string wybór = Console.ReadLine();
            decimal cena = 0;
            const string kodPromocyjny = "Giganci2023!";

            if(wybór == "1")
            {
                Console.WriteLine("Cena za klawiature wynosi 200zł");
                cena = 200;
            }
            else if(wybór=="2")
            {
                Console.WriteLine("Cena za myszkę wynosi 150zł");
                cena = 150;
            }
            else if(wybór=="3")
            {
                Console.WriteLine("Cena za obudowę wynosi 300zł");
                cena = 300;
            }
            else
            {
                Console.WriteLine("Nie ma takiej pozycji na liście");
            }

            Console.WriteLine("Czy posiadasz kod rabatowy? t/n");
            if(Console.ReadLine() == "t")
            {
                Console.WriteLine("Podaj kod rabatowy");
                if(Console.ReadLine() == kodPromocyjny)
                {
                    Console.WriteLine("Twoja cena została obniżona");
                    cena = cena * 0.7m;
                }
                else
                {
                    Console.WriteLine("Niepoprawny kod rabatowy");
                }
            }
            Console.WriteLine($"Cena końcowa wynosi {cena}");

            Console.ReadLine();
        }
    }
}
