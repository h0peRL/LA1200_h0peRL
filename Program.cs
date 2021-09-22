using System;

namespace LA_1200_Delvecchio
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.Clear();
            Random r = new Random();
            int randomNumber = r.Next(1, 100);
            int guess = 0;
            bool correct = false;
            int tries = 0;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Ich denke an eine Zahl zwischen 1-100. Was denkst du was meine Zahl ist? :).");

            while (!correct)
            {
                Console.Write("Deine Eingabe: ");
                string userInput = Console.ReadLine();

                if (!int.TryParse(userInput, out guess))
                {
                    Console.WriteLine("Bitte nur Zahlen eingeben.");
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    Console.Beep(530, 100);
                    continue;
                }

                if (guess < randomNumber)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Ein bisschen zu niedrig... Meine Zahl ist ein wenig höher.");
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    tries++;
                    Console.Beep(5000, 100);
                }
                else if (guess > randomNumber)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Etwas zu hoch... Meine Zahl ist ein wenig niedrieger.");
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    tries++;
                    Console.Beep(5000, 100);
                }
                else
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    correct = true;
                    tries++;
                    Console.WriteLine("Du bist ja richtig gut! Du hast meine Zahl gefunden!  (・w・) ");
                    Console.WriteLine("Deine Anzahl versuche:" + tries);
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;
                }           

            }

            Request:
            Console.WriteLine("Möchten sie weitersielen? ja/nein");

            string userInputnewGame = Console.ReadLine();

            if (userInputnewGame == "ja")
            {
                goto Start;

            }

            else if (userInputnewGame == "nein")
            {
                goto Finish;

            }

            else
            {
                Console.WriteLine("Bitte ja/nein eingeben.");
                goto Request;
            }

        Finish:            
            Console.WriteLine("Vielen Dank fürs spielen! Drücke eine beliebige taste um das Programm zu beenden. ");
            Console.ReadKey();
        }
    }
}