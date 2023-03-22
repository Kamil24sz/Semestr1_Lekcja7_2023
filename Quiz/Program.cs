using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int punkty = 0;
            Console.WriteLine("Witamy w quizie!");
            Console.WriteLine("Pytanie nr1: Który z podanych nie jest systemem operacyjnym?");
            Console.WriteLine("A: Windows");
            Console.WriteLine("B: Linuks");
            Console.WriteLine("C: Android");
            Console.WriteLine("D: Microsoft");
            if(Console.ReadLine() == "D")
            {
                punkty++;
            }
            Console.Clear();
           
            Console.WriteLine("Pytanie nr2: Który z podanych nie jest językiem programownia?");
            Console.WriteLine("A: Java");
            Console.WriteLine("B: C#");
            Console.WriteLine("C: HTML");
            Console.WriteLine("D: Python");
            if( Console.ReadLine() == "C") 
            {
                punkty++;
            }
            Console.Clear();

            //TWORZYMY SAMI 2-3 dodatkowe PYTANIA
            Console.WriteLine("Pytanie nr3: Jakim systemem liczbowym posługuje się komputer zapisując informacje?");
            Console.WriteLine("A: Dwójkowym");
            Console.WriteLine("B: Szesnastkowym");
            Console.WriteLine("C: Dziesiętnym");
            Console.WriteLine("D: Pozycyjnym");
            if (Console.ReadLine() == "A")
            {
                punkty++;
            }
            Console.Clear();

            Console.WriteLine("Pytanie nr4: Czym jest aplikacja?");
            Console.WriteLine("A: System operacyjny");
            Console.WriteLine("B: Użytkowy programem komputerowym");
            Console.WriteLine("C: Środowiskiem");
            Console.WriteLine("D: Ikoną");
            if (Console.ReadLine() == "B")
            {
                punkty++;
            }
            Console.Clear();

            Console.WriteLine("Pytanie nr5: Angielskie określenie oprogramowania to:");
            Console.WriteLine("A: Hardware");
            Console.WriteLine("B: Żadne z wymienionych");
            Console.WriteLine("C: Tracert");
            Console.WriteLine("D: Software");
            if (Console.ReadLine() == "D")
            {
                punkty++;
            }
            Console.Clear();

            Console.WriteLine($"Twoja liczba punktów zdobytych w quizie wynosi: {punkty}");
            if(punkty == 5)
            {
                Console.WriteLine("Gratulacje uzyskałeś 100%");
            }


            Console.ReadLine();
        }
    }
}
