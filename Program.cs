namespace Projektuppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuLength = 0;
            while (menuLength != 4)
            {
                Console.Clear();
                Console.WriteLine(
                    "-----Välkommen till Enhetskonverteringen-----" +
                    "\nVilken enhetskonvertering vill du testa?" +
                    "\n1.Längd" +
                    "\n2.Temperatur" +
                    "\n3.Vikt" +
                    "\n4.Avsluta programmet" +
                    "\n-----By: Filip Strand och Mattias Arvidsson-----\n"
                    );

                menuLength = Convert.ToInt32(Console.ReadLine());

                switch (menuLength)
                {
                    case 1:
                        Längd längd = new Längd();
                        längd.LengthConv();
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
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen. ");
                        break;
                }
            }
        }
    }
}