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
        public void menuLengthConv1()
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
                    "----------Längd----------" +
                    "\nVilken enhet vill du konvertera från?" +
                    "\n1.SI-enheter" +
                    "\n2.Amerikanska enheter" +
                    "\n3.Gå tillbaka till föregående meny." +
                    "\n-----------------------"
                    );

                // Läser användarens val
                Console.Write("\nAnge ditt val: ");
                string? menu1LengthInput = Console.ReadLine();

                // Validerar användarens input
                while (!int.TryParse(menu1LengthInput, out menuFrom) || menuFrom > 3 || menuFrom < 1)
                {
                    Console.WriteLine("\nFelaktig input, skriv in en siffra mellan 1 och 3.");
                    menu1LengthInput = Console.ReadLine();
                }

                // Hanterar användarens val
                switch (menuFrom)
                {
                    // Konverterar från SI-enheter
                    case 1:
                        // Skriver ut menyn för SI-enheter
                        Console.WriteLine(
                            "-------------------------" +
                            "\nVilken prefix har enheten som du vill konvertera från?" +
                            "\n1.Centimeter" +
                            "\n2.Meter" +
                            "\n3.Kilometer" +
                            "\n-----------------------"
                            );

                        // Läser användarens val för SI-enheter
                        Console.Write("\nAnge ditt val: ");
                        SImenuFromInput = Console.ReadLine();

                        // Validerar användarens input
                        while (!int.TryParse(SImenuFromInput, out fromUnit) || fromUnit > 3 || fromUnit < 1)
                        {
                            Console.WriteLine("\nFelaktig input, ange en siffra mellan 1 och 3.");
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
                        menuLengthConv2();
                        break;
                    // Konverterar från amerikanska enheter
                    case 2:
                        // Skriver ut menyn för amerikanska enheter
                        Console.WriteLine(
                            "-------------------------" +
                            "\nVilken prefix har enheten som du vill konvertera från?" +
                            "\n1.Feet" +
                            "\n2.Yards" +
                            "\n3.Miles" +
                            "\n-----------------------"
                            );

                        // Läser användarens val för amerikanska enheter
                        Console.Write("\nAnge ditt val: ");
                        USmenuFromInput = Console.ReadLine();

                        // Validerar användarens input
                        while (!int.TryParse(USmenuFromInput, out fromUnit) || fromUnit > 3 || fromUnit < 1)
                        {
                            Console.WriteLine("\nFelaktig input, ange en siffra mellan 1 och 3.");
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
                        menuLengthConv2();
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
            string menuLengthConv2()
            {
                // Skriver ut menyn för att välja enhet att konvertera till
                Console.WriteLine(
                    "-------------------------" +
                    "\nVilken prefix har enheten som du vill konvertera till?" +
                    "\n1.Centimeter" +
                    "\n2.Meter" +
                    "\n3.Kilometer" +
                    "\n4.Feet" +
                    "\n5.Yards" +
                    "\n6.Miles" +
                    "\n-----------------------"
                    );

                // Läser användarens val för enhet att konvertera till
                Console.Write("\nAnge ditt val: ");
                string? menutoInput = Console.ReadLine();

                // Validerar användarens input
                while (!int.TryParse(menutoInput, out toUnit) || toUnit > 6 || toUnit < 1)
                {
                    Console.WriteLine("\nFelaktig input, ange en siffra mellan 1 och 6.");
                    menutoInput = Console.ReadLine();
                }

                // Hanterar användarens val för enhet att konvertera till
                switch (toUnit)
                {
                    case 1:
                        toUnitPrefix = "Centimeter";
                        valueInput();
                        break;
                    case 2:
                        toUnitPrefix = "Meter";
                        valueInput();
                        break;
                    case 3:
                        toUnitPrefix = "Kilometer";
                        valueInput();
                        break;
                    case 4:
                        toUnitPrefix = "Feet";
                        valueInput();
                        break;
                    case 5:
                        toUnitPrefix = "Yards";
                        valueInput();
                        break;
                    case 6:
                        toUnitPrefix = "Miles";
                        valueInput();
                        break;
                    default:
                        Console.WriteLine("\nOgiltigt val. Försök igen. ");
                        break;
                }
                return toUnitPrefix;
            }

            // Metod för att mata in värdet som ska konverteras
            void valueInput()
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

            // Metod för att genomföra konvertering för SI-enheter
            void ConvertLengthSI()
            {
                // Beroende på enheten som konverteras från och till, använd rätt konverteringsmetod
                switch (fromUnitPrefix)
                {
                    case "Centimeter":
                        switch (toUnitPrefix)
                        {
                            case "Centimeter":
                                answer = value;
                                break;
                            case "Meter":
                                answer = Math.Round(CentimeterToMeter(value), 2);
                                break;
                            case "Kilometer":
                                answer = Math.Round(CentimeterToKilometer(value), 15);
                                break;
                            case "Feet":
                                answer = Math.Round(CentimeterToFoot(value), 9);
                                break;
                            case "Yards":
                                answer = Math.Round(CentimeterToYards(value), 9);
                                break;
                            case "Miles":
                                answer = Math.Round(CentimeterToMiles(value), 15);
                                break;
                            default:
                                throw new ArgumentException("\nOgiltig enhet");
                        }
                        break;
                    case "Meter":
                        switch (toUnitPrefix)
                        {
                            case "Centimeter":
                                answer = Math.Round(MeterToCentimeter(value), 2);
                                break;
                            case "Meter":
                                answer = value;
                                break;
                            case "Kilometer":
                                answer = Math.Round(MeterToKilometer(value), 3);
                                break;
                            case "Feet":
                                answer = Math.Round(MeterToFoot(value), 9);
                                break;
                            case "Yards":
                                answer = Math.Round(MeterToYards(value), 10);
                                break;
                            case "Miles":
                                answer = Math.Round(MeterToMiles(value), 10);
                                break;
                            default:
                                throw new ArgumentException("\nOgiltig enhet");
                        }
                        break;
                    case "Kilometer":
                        switch (toUnitPrefix)
                        {
                            case "Centimeter":
                                answer = Math.Round(KilometerToCentimeter(value), 2);
                                break;
                            case "Meter":
                                answer = Math.Round(KilometerToMeter(value), 2);
                                break;
                            case "Kilometer":
                                answer = value;
                                break;
                            case "Feet":
                                answer = Math.Round(KilometerToFoot(value), 2);
                                break;
                            case "Yards":
                                answer = Math.Round(KilometerToYards(value), 10);
                                break;
                            case "Miles":
                                answer = Math.Round(KilometerToMiles(value), 10);
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
            // Metod för att genomföra konvertering för amerikanska enheter
            void ConvertLengthUS()
            {
                // Beroende på enheten som konverteras från och till, använd rätt konverteringsmetod
                switch (fromUnitPrefix)
                {
                    case "Feet":
                        switch (toUnitPrefix)
                        {
                            case "Centimeter":
                                answer = Math.Round(FootToCentimeter(value), 2);
                                break;
                            case "Meter":
                                answer = Math.Round(FootToMeter(value), 4);
                                break;
                            case "Kilometer":
                                answer = Math.Round(FootToKilometer(value), 7);
                                break;
                            case "Feet":
                                answer = value;
                                break;
                            case "Yards":
                                answer = Math.Round(FootToYards(value), 10);
                                break;
                            case "Miles":
                                answer = Math.Round(FootToMiles(value), 10);
                                break;
                            default:
                                throw new ArgumentException("Ogiltig enhet");
                        }
                        break;
                    case "Yards":
                        switch (toUnitPrefix)
                        {
                            case "Centimeter":
                                answer = Math.Round(YardsToCentimeter(value), 2);
                                break;
                            case "Meter":
                                answer = Math.Round(YardsToMeter(value), 4);
                                break;
                            case "Kilometer":
                                answer = Math.Round(YardsToKilometer(value), 7);
                                break;
                            case "Feet":
                                answer = Math.Round(YardsToFoot(value), 2);
                                break;
                            case "Yards":
                                answer = value;
                                break;
                            case "Miles":
                                answer = Math.Round(YardsToMiles(value), 10);
                                break;
                            default:
                                throw new ArgumentException("Ogiltig enhet");
                        }
                        break;
                    case "Miles":
                        switch (toUnitPrefix)
                        {
                            case "Centimeter":
                                answer = Math.Round(MilesToCentimeter(value), 2);
                                break;
                            case "Meter":
                                answer = Math.Round(MilesToMeter(value), 3);
                                break;
                            case "Kilometer":
                                answer = Math.Round(MilesToKilometer(value), 6);
                                break;
                            case "Feet":
                                answer = Math.Round(MilesToFoot(value), 2);
                                break;
                            case "Yards":
                                answer = Math.Round(MilesToYards(value), 2);
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

            // Metoder för olika konverteringsfunktioner (tagna från https://www.rapidtables.com/convert/length/index.html)
            // Konverteringsfunktioner för SI-enheter
            double CentimeterToMeter(double Centimeter)
            {
                return Centimeter / 100;
            }
            double CentimeterToKilometer(double Centimeter)
            {
                return Centimeter / 100000;
            }
            double CentimeterToFoot(double Centimeter)
            {
                return Centimeter / 30.48;
            }
            double CentimeterToYards(double Centimeter)
            {
                return Centimeter / 91.44;
            }
            double CentimeterToMiles(double Centimeter)
            {
                return Centimeter / 160934.4;
            }
            double MeterToCentimeter(double Meters)
            {
                return Meters * 100;
            }
            double MeterToKilometer(double Meters)
            {
                return Meters / 1000;
            }
            double MeterToFoot(double Meters)
            {
                return Meters / 0.3048;
            }
            double MeterToYards(double Meters)
            {
                return Meters / 0.9144;
            }
            double MeterToMiles(double Meters)
            {
                return Meters / 1609.344;
            }
            double KilometerToCentimeter(double KiloMeters)
            {
                return KiloMeters * 100000;
            }
            double KilometerToMeter(double KiloMeters)
            {
                return KiloMeters * 1000;
            }
            double KilometerToFoot(double KiloMeters)
            {
                return KiloMeters * 3280.84;
            }
            double KilometerToYards(double KiloMeters)
            {
                return KiloMeters / 0.0009144;
            }
            double KilometerToMiles(double KiloMeters)
            {
                return KiloMeters / 1.609344;
            }
            // Konverteringsfunktioner för amerikanska enheter
            double FootToCentimeter(double Foot)
            {
                return Foot * 30.48;
            }
            double FootToMeter(double Foot)
            {
                return Foot * 0.3048;
            }
            double FootToKilometer(double Foot)
            {
                return Foot / 3280.84;
            }
            double FootToYards(double Foot)
            {
                return Foot / 3;
            }
            double FootToMiles(double Foot)
            {
                return Foot / 5280;
            }
            double YardsToCentimeter(double Yard)
            {
                return Yard * 91.44;
            }
            double YardsToMeter(double Yard)
            {
                return Yard * 0.9144;
            }
            double YardsToKilometer(double Yard)
            {
                return Yard * 0.0009144;
            }
            double YardsToFoot(double Yard)
            {
                return Yard * 3;
            }
            double YardsToMiles(double Yard)
            {
                return Yard / 1760;
            }
            double MilesToCentimeter(double Miles)
            {
                return Miles * 160934.4;
            }
            double MilesToMeter(double Miles)
            {
                return Miles * 1609.344;
            }
            double MilesToKilometer(double Miles)
            {
                return Miles * 1.609344;
            }
            double MilesToFoot(double Miles)
            {
                return Miles * 5280;
            }
            double MilesToYards(double Miles)
            {
                return Miles * 1760;
            }
        }
    }
}
