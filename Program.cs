using System;

namespace Moment4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapar en lagring för heltal
            Storage<int> heltalsLagring = new Storage<int>();
            heltalsLagring.AddItem(10);  // Lägger till ett tal
            heltalsLagring.AddItem(25);  // Lägger till ett till
            Console.WriteLine("Heltal i lagringen:");
            heltalsLagring.PrintAll();   // Skriver ut alla heltal

            // Skapar en lagring för strängar
            Storage<string> textLagring = new Storage<string>();
            textLagring.AddItem("Hej");
            textLagring.AddItem("Programmering");
            Console.WriteLine("Texter i lagringen:");
            textLagring.PrintAll();     // Skriver ut alla texter

            // Frågar användaren om ett heltal
            Console.WriteLine("Skriv ett heltal:");

            try
            {
                int tal = Convert.ToInt32(Console.ReadLine()); // Försöker läsa tal
                Console.WriteLine($"Du skrev: {tal}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Felaktigt format, du måste skriva ett heltal.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Talet var för stort eller för litet.");
            }
            finally
            {
                Console.WriteLine("Input attempt complete.");
            }

            Console.ReadKey(); // Så att fönstret inte stängs direkt
        }
    }
}
