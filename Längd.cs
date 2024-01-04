using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projektuppgift
{
    public class Längd
    {
        // Metod för huvudmenyn för längdkonvertering
        public void Menu1()
        {
            // Variabler för användarens input och konverteringsresultat
            double answer;
            double value;
            int fromUnit;
            int toUnit;
            string? SImenuFromInput = default;
            string? USmenuFromInput = default;
            string? fromUnitPrefix = default;
            string? toUnitPrefix = default;
            int menuFrom = 0;
            // Sökväg för att spara resultatfilen
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
            // Huvudloop för menyn
            while (menuFrom != 3)
            {
                // Skriver ut huvudmenyn
                Console.WriteLine(
                    "-------------------Längd-------------------" +
                    "\nVilken enhet vill du konvertera från?" +
                    "\n1. SI-enheter" +
                    "\n2. Amerikanska enheter" +
                    "\n3. Gå tillbaka till föregående meny." +
                    "\n-------------------------------------------"
                    );

                // Läser användarens val
                Console.Write("\nAnge ditt val: ");
                string? menu1LengthInput = Console.ReadLine();

                // Validerar användarens input
                while (!int.TryParse(menu1LengthInput, out menuFrom) || menuFrom > 3 || menuFrom < 1)
                {
                    Console.WriteLine("\nFelaktig input, skriv in en siffra mellan 1 och 3.");
                    Console.Write("\nAnge ditt val: ");
                    menu1LengthInput = Console.ReadLine();
                }

                // Hanterar användarens val
                switch (menuFrom)
                {
                    // Konverterar från SI-enheter
                    case 1:
                        // Skriver ut menyn för SI-enheter
                        Console.WriteLine(
                            "-------------------------------------------" +
                            "\nVilken prefix har enheten som du vill konvertera från?" +
                            "\n1. Centimeter" +
                            "\n2. Meter" +
                            "\n3. Kilometer" +
                            "\n-------------------------------------------"
                            );

                        // Läser användarens val för SI-enheter
                        Console.Write("\nAnge ditt val: ");
                        SImenuFromInput = Console.ReadLine();

                        // Validerar användarens input
                        while (!int.TryParse(SImenuFromInput, out fromUnit) || fromUnit > 3 || fromUnit < 1)
                        {
                            Console.WriteLine("\nFelaktig input, ange en siffra mellan 1 och 3.");
                            Console.Write("\nAnge ditt val: ");
                            SImenuFromInput = Console.ReadLine();
                        }

                        // Hanterar val för SI-enheter
                        switch (fromUnit)
                        {
                            case 1:
                                fromUnitPrefix = "Centimeter";
                                break;
                            case 2:
                                fromUnitPrefix = "Meter";
                                break;
                            case 3:
                                fromUnitPrefix = "Kilometer";
                                break;
                            default:
                                Console.WriteLine("\nOgiltigt val. Försök igen. ");
                                break;
                        }
                        // Går till nästa meny för att välja enhet att konvertera till
                        Menu2();
                        break;
                    // Konverterar från amerikanska enheter
                    case 2:
                        // Skriver ut menyn för amerikanska enheter
                        Console.WriteLine(
                            "-------------------------------------------" +
                            "\nVilken prefix har enheten som du vill konvertera från?" +
                            "\n1. Feet" +
                            "\n2. Yards" +
                            "\n3. Miles" +
                            "\n-------------------------------------------"
                            );

                        // Läser användarens val för amerikanska enheter
                        Console.Write("\nAnge ditt val: ");
                        USmenuFromInput = Console.ReadLine();

                        // Validerar användarens input
                        while (!int.TryParse(USmenuFromInput, out fromUnit) || fromUnit > 3 || fromUnit < 1)
                        {
                            Console.WriteLine("\nFelaktig input, ange en siffra mellan 1 och 3.");
                            Console.Write("\nAnge ditt val: ");
                            USmenuFromInput = Console.ReadLine();
                        }

                        // Hanterar val för amerikanska enheter
                        switch (fromUnit)
                        {
                            case 1:
                                fromUnitPrefix = "Feet";
                                break;
                            case 2:
                                fromUnitPrefix = "Yards";
                                break;
                            case 3:
                                fromUnitPrefix = "Miles";
                                break;
                            default:
                                Console.WriteLine("\nOgiltigt val. Försök igen. ");
                                break;
                        }
                        // Går till nästa meny för att välja enhet att konvertera till
                        Menu2();
                        break;
                    // Avslutar programmet
                    case 3:
                        break;
                    // Ogiltigt val
                    default:
                        Console.WriteLine("\nOgiltigt val. Försök igen. ");
                        break;
                }
            }

            // Metod för att välja enhet att konvertera till
            string Menu2()
            {
                // Skriver ut menyn för att välja enhet att konvertera till
                Console.WriteLine(
                    "-------------------------------------------" +
                    "\nVilken prefix har enheten som du vill konvertera till?" +
                    "\n1. Centimeter" +
                    "\n2. Meter" +
                    "\n3. Kilometer" +
                    "\n4. Feet" +
                    "\n5. Yards" +
                    "\n6. Miles" +
                    "\n-------------------------------------------"
                    );

                // Läser användarens val för enhet att konvertera till
                Console.Write("\nAnge ditt val: ");
                string? menutoInput = Console.ReadLine();

                // Validerar användarens input
                while (!int.TryParse(menutoInput, out toUnit) || toUnit > 6 || toUnit < 1)
                {
                    Console.WriteLine("\nFelaktig input, ange en siffra mellan 1 och 6.");
                    Console.Write("\nAnge ditt val: ");
                    menutoInput = Console.ReadLine();
                }

                // Hanterar användarens val för enhet att konvertera till
                switch (toUnit)
                {
                    case 1:
                        toUnitPrefix = "Centimeter";
                        ValueInput();
                        break;
                    case 2:
                        toUnitPrefix = "Meter";
                        ValueInput();
                        break;
                    case 3:
                        toUnitPrefix = "Kilometer";
                        ValueInput();
                        break;
                    case 4:
                        toUnitPrefix = "Feet";
                        ValueInput();
                        break;
                    case 5:
                        toUnitPrefix = "Yards";
                        ValueInput();
                        break;
                    case 6:
                        toUnitPrefix = "Miles";
                        ValueInput();
                        break;
                    default:
                        Console.WriteLine("\nOgiltigt val. Försök igen. ");
                        break;
                }
                return toUnitPrefix;
            }

            // Metod för att mata in värdet som ska konverteras
            void ValueInput()
            {
                // Läser användarens input för värdet som ska konverteras
                Console.WriteLine($"\nHur många {fromUnitPrefix} vill du omvandla?");
                Console.Write("\nAnge värdet: ");
                string? valueInput = Console.ReadLine();

                // Validerar användarens input
                while (!double.TryParse(valueInput, out value) || value < 0)
                {
                    Console.WriteLine("\nFelaktig input, ange ett numeriskt värde som är större än 0.");
                    Console.Write("\nAnge värdet: ");
                    valueInput = Console.ReadLine();
                }
                // Beroende på enheten som konverteras från, anropa rätt metod för konvertering
                if (fromUnitPrefix == "Centimeter")
                {
                    ConvertLengthSI();
                }
                else if (fromUnitPrefix == "Meter")
                {
                    ConvertLengthSI();
                }
                else if (fromUnitPrefix == "Kilometer")
                {
                    ConvertLengthSI();
                }
                else if (fromUnitPrefix == "Feet")
                {
                    ConvertLengthUS();
                }
                else if (fromUnitPrefix == "Yards")
                {
                    ConvertLengthUS();
                }
                else if (fromUnitPrefix == "Miles")
                {
                    ConvertLengthUS();
                }
            }

            // Metod för att genomföra konvertering för SI-enheter (tagna från https://www.rapidtables.com/convert/length/index.html)
            void ConvertLengthSI()
            {
                // Beroende på enheten som konverteras från och till, används rätt konverteringsmetod
                switch (fromUnitPrefix)
                {
                    case "Centimeter":
                        switch (toUnitPrefix)
                        {
                            case "Centimeter":
                                answer = value;
                                break;
                            case "Meter":
                                answer = Math.Round(value / 100, 2);
                                break;
                            case "Kilometer":
                                answer = Math.Round(value / 100000, 15);
                                break;
                            case "Feet":
                                answer = Math.Round(value / 30.48, 9);
                                break;
                            case "Yards":
                                answer = Math.Round(value / 91.44, 9);
                                break;
                            case "Miles":
                                answer = Math.Round(value / 160934.4, 15);
                                break;
                            default:
                                throw new ArgumentException("\nOgiltig enhet");
                        }
                        break;
                    case "Meter":
                        switch (toUnitPrefix)
                        {
                            case "Centimeter":
                                answer = Math.Round(value * 100, 2);
                                break;
                            case "Meter":
                                answer = value;
                                break;
                            case "Kilometer":
                                answer = Math.Round(value / 1000, 3);
                                break;
                            case "Feet":
                                answer = Math.Round(value / 0.3048, 9);
                                break;
                            case "Yards":
                                answer = Math.Round(value / 0.9144, 10);
                                break;
                            case "Miles":
                                answer = Math.Round(value / 1609.344, 10);
                                break;
                            default:
                                throw new ArgumentException("\nOgiltig enhet");
                        }
                        break;
                    case "Kilometer":
                        switch (toUnitPrefix)
                        {
                            case "Centimeter":
                                answer = Math.Round(value * 100000, 2);
                                break;
                            case "Meter":
                                answer = Math.Round(value * 1000, 2);
                                break;
                            case "Kilometer":
                                answer = value;
                                break;
                            case "Feet":
                                answer = Math.Round(value * 3280.84, 2);
                                break;
                            case "Yards":
                                answer = Math.Round(value / 0.0009144, 10);
                                break;
                            case "Miles":
                                answer = Math.Round(value / 1.609344, 10);
                                break;
                            default:
                                throw new ArgumentException("\nOgiltig enhet");
                        }
                        break;
                    default:
                        throw new ArgumentException("\nOgiltig enhet");
                }
                // Anropar funktionen för att visa resultatet
                Answer();
            }
            // Metod för att genomföra konvertering för amerikanska enheter (tagna från https://www.rapidtables.com/convert/length/index.html)
            void ConvertLengthUS()
            {
                // Beroende på enheten som konverteras från och till, används rätt konverteringsmetod
                switch (fromUnitPrefix)
                {
                    case "Feet":
                        switch (toUnitPrefix)
                        {
                            case "Centimeter":
                                answer = Math.Round(value * 30.48, 2);
                                break;
                            case "Meter":
                                answer = Math.Round(value * 0.3048, 4);
                                break;
                            case "Kilometer":
                                answer = Math.Round(value / 3280.84, 7);
                                break;
                            case "Feet":
                                answer = value;
                                break;
                            case "Yards":
                                answer = Math.Round(value / 3, 10);
                                break;
                            case "Miles":
                                answer = Math.Round(value / 5280, 10);
                                break;
                            default:
                                throw new ArgumentException("Ogiltig enhet");
                        }
                        break;
                    case "Yards":
                        switch (toUnitPrefix)
                        {
                            case "Centimeter":
                                answer = Math.Round(value * 91.44, 2);
                                break;
                            case "Meter":
                                answer = Math.Round(value * 0.9144, 4);
                                break;
                            case "Kilometer":
                                answer = Math.Round(value * 0.0009144, 7);
                                break;
                            case "Feet":
                                answer = Math.Round(value * 3, 2);
                                break;
                            case "Yards":
                                answer = value;
                                break;
                            case "Miles":
                                answer = Math.Round(value / 1760, 10);
                                break;
                            default:
                                throw new ArgumentException("Ogiltig enhet");
                        }
                        break;
                    case "Miles":
                        switch (toUnitPrefix)
                        {
                            case "Centimeter":
                                answer = Math.Round(value * 160934.4, 2);
                                break;
                            case "Meter":
                                answer = Math.Round(value * 1609.344, 3);
                                break;
                            case "Kilometer":
                                answer = Math.Round(value * 1.609344, 6);
                                break;
                            case "Feet":
                                answer = Math.Round(value * 5280, 2);
                                break;
                            case "Yards":
                                answer = Math.Round(value * 1760, 2);
                                break;
                            case "Miles":
                                answer = value;
                                break;
                            default:
                                throw new ArgumentException("\nOgiltig enhet");
                        }
                        break;
                    default:
                        throw new ArgumentException("\nOgiltig enhet");  
                }
                // Anropar funktionen för att visa resultatet
                Answer();
            }

            // Metod för att visa konverteringsresultatet och spara det i en textfil
            void Answer()
            {
                Console.WriteLine($"\nSvar: {value} {fromUnitPrefix} är {answer} {toUnitPrefix}");
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Resultat.txt"), true))
                {
                    outputFile.WriteLine($"\nSvar: {value} {fromUnitPrefix} är {answer} {toUnitPrefix}");
                }
            }
        }
    }
}
