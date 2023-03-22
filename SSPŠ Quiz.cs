using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SSPŠ_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 0;

            Console.WriteLine("Vítejte v SSPŠ kvízu");
            Thread.Sleep(5000);
            Console.WriteLine("Vaším cílem je odpovědět na 5 otázek, které se týkají SSPŠ");
            Thread.Sleep(5000);
            Console.WriteLine("Vzorový příklad:");
            Console.WriteLine("Kdo je aktuálním prezidentem ČR?");
            Console.WriteLine();
            Console.WriteLine("A) Petr Pavel                    B) Andrej Babiš");
            Console.WriteLine("C) Miloš Zeman                   D) Tomio Okamura");
            Console.WriteLine();
            Console.WriteLine("Vaše odpověď : A");
            Console.WriteLine();
            Console.WriteLine("Správně, získáváte 1 bod");
            Console.WriteLine("Váš bodový stav je : 1");
            Thread.Sleep(10000);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1) Na jaké adrese se nachází SSPŠ?");
            Console.WriteLine();
            Console.WriteLine("A) Bolzanova 800                 B) Preslova 72/25");
            Console.WriteLine("C) Vlašská 591/13                D) Malinovského nám. 624/3");
            Console.WriteLine();
            Console.WriteLine("Vaše odpověď : ");

            string answer = Console.ReadLine();
            if (answer == "B" || answer == "b")
            {
                Console.WriteLine("Správně, získáváš 1 bod");
                points = points + 1;
                Console.WriteLine("Váš bodový stav je : " + points);
            }
            else
            {
                Console.WriteLine("Špatně, správná odpověď je B");
                Console.WriteLine("Váš bodový stav je " + points);
            }
            Thread.Sleep(5000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("2) V jakém roce byla SSPŠ založena?");
            Console.WriteLine();
            Console.WriteLine("A) 1901               B) 1856");
            Console.WriteLine("C) 1914               D) 1934");
            Console.WriteLine();
            Console.WriteLine("Vaše odpověď : ");
            answer = Console.ReadLine();
            if (answer == "A" || answer == "a")
            {
                Console.WriteLine("Správně, získáváš 1 bod");
                points = points + 1;
                Console.WriteLine("Váš bodový stav je : " + points);
            }
            else
            {
                Console.WriteLine("Špatně, správná odpověď je A");
                Console.WriteLine("Váš bodový stav je " + points);
            }
            Thread.Sleep(5000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("3) Kdo je aktuálně ředitelem SSPŠ?");
            Console.WriteLine();
            Console.WriteLine("A) Jeff Bazos                   B) Srabko Ráblík");
            Console.WriteLine("C) Filip Kalista                D) Radko Sáblík");
            Console.WriteLine();
            Console.WriteLine("Vaše odpověď : ");
            answer = Console.ReadLine();
            if (answer == "D" || answer == "d")
            {
                Console.WriteLine("Správně, získáváš 1 bod");
                points = points + 1;
                Console.WriteLine("Váš bodový stav je : " + points);
            }
            else
            {
                Console.WriteLine("Špatně, správná odpověď je D");
                Console.WriteLine("Váš bodový stav je " + points);
            }
            Thread.Sleep(5000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("4) Jaké je motto SSPŠ?");
            Console.WriteLine();
            Console.WriteLine("A) Buďme vděčni Bohu                              B) Kdo pozdě chodí, sám sobě škodí");
            Console.WriteLine("C) Nebojíme se budoucnosti, tvoříme ji            D) Jednota, spravedlnost a důvěra");
            Console.WriteLine();
            Console.WriteLine("Vaše odpověď : ");
            answer = Console.ReadLine();
            if (answer == "C" || answer == "c")
            {
                Console.WriteLine("Správně, získáváš 1 bod");
                points = points + 1;
                Console.WriteLine("Váš bodový stav je : " + points);
            }
            else
            {
                Console.WriteLine("Špatně, správná odpověď je C");
                Console.WriteLine("Váš bodový stav je " + points);
            }
            Thread.Sleep(5000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("5) V jakém žebříčku se SSPŠ umístila??");
            Console.WriteLine();
            Console.WriteLine("A) V žebříčku 8 nejzajímavějších SŠ               B) V žebříčku 10 nejlepších SŠ");
            Console.WriteLine("C) V žebříčku 15 nejmodernějších SŠ               D) V žebříčku 20 míst, které byste měli v Praze navštívit ");
            Console.WriteLine();
            Console.WriteLine("Vaše odpověď : ");
            answer = Console.ReadLine();
            if (answer == "A" || answer == "a")
            {
                Console.WriteLine("Správně, získáváš 1 bod");
                points = points + 1;
                Console.WriteLine("Váš bodový stav je : " + points);
            }
            else
            {
                Console.WriteLine("Špatně, správná odpověď je A");
                Console.WriteLine("Váš bodový stav je " + points);
            }
            Thread.Sleep(5000);
        }
    }
}
