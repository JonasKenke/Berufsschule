using System;
using System.Linq;
using System.Threading;

namespace Bankautomat
{
    internal class Program
    {
        static void Main()
        {
            int[] blocklist = new int[] { 9999, 8888, 7777, 6666, 5555, 4444, 3333, 2222, 1111, 0000 };
            int avalibleMoney = 3000;
            Boolean below1K;
            int pin = 1234;
            while (avalibleMoney >= 1000)
            {
                Console.WriteLine("Wilkommen");
                Console.WriteLine("Geben sie den Betrag zu abheben ein.");
                if (avalibleMoney < 2000)
                {
                    Console.WriteLine("Sie können nur 1000 abheben.");
                    below1K = true;

                }
                else
                {
                    Console.WriteLine("Sie können maximal 2000 abheben.");
                    below1K = false;
                }
                int betrag = Convert.ToInt32(Console.ReadLine());
                if (betrag > 2000)
                {
                    if (below1K)
                    {
                        Console.WriteLine("Sie können nur 1000 abheben.");
                    }
                    else
                    {
                        Console.WriteLine("Sie können maximal 2000 abheben.");
                    }
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }
                if (below1K && betrag > 1000)
                {
                    Console.WriteLine("Sie können nur 1000 abheben.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }

                int pinEingabe;
                int origen;
                int position;
                int trys = 0;
                string fullstring = "";
                Boolean restart = false;

                do
                {
                    Console.WriteLine("Bitte geben Sie eine PIN ein: ");
                    for (int i = 0; i < 4; i++)
                    {
                        position = Console.CursorTop;
                        char c = Console.ReadKey().KeyChar;
                        if (Char.IsNumber(c))
                        {
                            fullstring += c;
                        }
                        else
                        {
                            Console.WriteLine("\nBitte geben Sie nur Zahlen ein.\n");
                            restart = true;
                            break;

                        }
                        origen = Console.CursorLeft;
                        Thread.Sleep(100);
                        Console.SetCursorPosition(origen - 1, position);
                        Console.Write("*");
                    }

                    if (restart)
                    {
                        restart = false;
                        fullstring = "";
                        Thread.Sleep(1000);
                        continue;
                    }

                    pinEingabe = Convert.ToInt32(fullstring);
                    fullstring = "";

                    if (blocklist.Contains(pinEingabe))
                    {
                        Console.WriteLine("\nIhre Karte wurde eingezogen.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    }


                    if (pinEingabe == pin)
                    {
                        Console.WriteLine("\nSie haben erfolgreich " + betrag + " abgehoben");
                        avalibleMoney -= betrag;
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        trys++;
                        Console.WriteLine("\nFalsche PIN");
                    }
                }
                while (trys < 3);

                if (trys == 3)
                {
                    Console.WriteLine("Sie haben 3 mal die falsche PIN eingegeben. Karte wird eingezogen.");
                    Thread.Sleep(1000);
                    Console.Clear();
                }

            }
            Console.WriteLine("Out of order");

        }
    }
}
