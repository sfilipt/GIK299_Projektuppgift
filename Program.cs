namespace Projektuppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuLength = 0;
            string? menuInput = default;
            while (menuLength != 4)
            {
                Console.WriteLine(
                    "\n-----Välkommen till Enhetskonverteringen-----" +
                    "\nVilken enhetskonvertering vill du testa?" +
                    "\n1.Längd" +
                    "\n2.Temperatur" +
                    "\n3.Vikt" +
                    "\n4.Avsluta programmet" +
                    "\n-----By: Filip Strand och Mattias Arvidsson-----\n"
                    );

                menuInput = Console.ReadLine();

                while (!int.TryParse(menuInput, out menuLength) || menuLength > 4 || menuLength < 1)
                {
                    Console.WriteLine("\nFelaktig input, ange en siffra mellan 1 och 3.");
                    Console.Write("\nAnge ditt val: ");
                    menuInput = Console.ReadLine();
                }

                switch (menuLength)
                {
                    case 1:
                        Längd längd = new Längd();
                        längd.Menu1();
                        break;
                    case 2:
                        Temperatur temp = new Temperatur();
                        temp.Menu1();
                        break;
                    case 3:
                        Vikt vikt = new Vikt();
                        vikt.Menu1();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen. ");
                        break;
                }
            }
        }
    }
}