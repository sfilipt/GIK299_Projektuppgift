namespace Projektuppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variabler för användarens input och konverteringsresultat
            int menuLength = 0;
            string? menuInput = default;
            // While-loop för att hålla programmet igång tills användaren väljer att avsluta
            while (menuLength != 4)
            {
                // Menyutskrift
                Console.WriteLine(
                    "\n-----Välkommen till Enhetskonverteringen-----" +
                    "\nVilken enhetskonvertering vill du testa?" +
                    "\n1.Längd" +
                    "\n2.Temperatur" +
                    "\n3.Vikt" +
                    "\n4.Avsluta programmet" +
                    "\n-----By: Filip Strand och Mattias Arvidsson-----\n"
                    );

                // Läser användarens inmatning
                menuInput = Console.ReadLine();

                // Validerar inmatningen för att säkerställa att den är en siffra mellan 1 och 4
                while (!int.TryParse(menuInput, out menuLength) || menuLength > 4 || menuLength < 1)
                {
                    Console.WriteLine("\nFelaktig input, ange en siffra mellan 1 och 3.");
                    Console.Write("\nAnge ditt val: ");
                    menuInput = Console.ReadLine();
                }

                // Använder en switch-sats för att välja rätt konverteringsmeny baserat på användarens val
                switch (menuLength)
                {
                    case 1:
                        // Skapa en instans av Längd-klassen och anropa dess Menu1-metod
                        Längd längd = new Längd();
                        längd.Menu1();
                        break;
                    case 2:
                        // Skapa en instans av Temperatur-klassen och anropa dess Menu1-metod
                        Temperatur temp = new Temperatur();
                        temp.Menu1();
                        break;
                    case 3:
                        // Skapa en instans av Vikt-klassen och anropa dess Menu1-metod
                        Vikt vikt = new Vikt();
                        vikt.Menu1();
                        break;
                    case 4:
                        // Avsluta programmet om användaren väljer alternativ 4
                        break;
                    default:
                        // Meddelande om ogiltigt val
                        Console.WriteLine("Ogiltigt val. Försök igen. ");
                        break;
                }
            }
        }
    }
}