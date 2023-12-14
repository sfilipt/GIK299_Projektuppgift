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
        public static void LengthConv()
        {
            while (true)
            {
                Console.WriteLine(
                    "----------Längd----------" +
                    "\nVilken enhet vill du konvertera från?" +
                    "\n1.SI-enheter" +
                    "\n2.Amerikanska enheter" +
                    "\n3.Avsluta längd konverteraren" +
                    "\n-----------------------\n"
                    );
                
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        LengthConvSItoAmerican();
                        break;
                    case 2:
                        LengthConvAmericantoSI();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default: Console.WriteLine("Ogiltigt val. Försök igen. ");
                        break;
                }

                void LengthConvSItoAmerican()
                {
                    Console.WriteLine("Välj enhet att konvertera från (cm, m, km): ");
                    string fromSIUnit = Console.ReadLine() ?? "";

                    Console.WriteLine("Ange värdet: ");
                    double value;

                    while (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("Ogiltig inmatning. Försök igen. ");
                    }

                    Console.WriteLine("Välj enhet att konvertera till (cm, m, km, feet, yards, miles): ");
                    string toSIorUSUnit = Console.ReadLine() ?? "";

                    double convertedValue = ConvertLengthSI(value, fromSIUnit, toSIorUSUnit);

                    Console.WriteLine($"{value} {fromSIUnit} motsvarar {convertedValue} {toSIorUSUnit}");

                    while (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("Ogiltig inmatning. Försök igen. ");
                    }
                }

                void LengthConvAmericantoSI()
                {
                    Console.WriteLine("Välj enhet att konvertera från (feet, yards, miles): ");
                    string fromUSUnit = Console.ReadLine() ?? "";

                    Console.WriteLine("Ange värdet: ");
                    double value;

                    while (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("Ogiltig inmatning. Försök igen. ");
                    }

                    Console.WriteLine("Välj enhet att konvertera till (cm, m, km, feet, yards, miles): ");
                    string toUSorSIUnit = Console.ReadLine() ?? "";

                    double convertedValue = ConvertLengthUS(value, fromUSUnit, toUSorSIUnit);

                    Console.WriteLine($"{value} {fromUSUnit} motsvarar {convertedValue} {toUSorSIUnit}");

                    while (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("Ogiltig inmatning. Försök igen. ");
                    }
                }
                
                static double ConvertLengthSI(double value, string fromSIUnit, string toSIorUSUnit)
                {
                    switch (fromSIUnit)
                    {
                        case "CMtoM":
                            return CentimeterToMeter(value);
                        case "CMtoKM":
                            return CentimeterToKilometer(value);
                        case "CMtoFoot":
                            return CentimeterToFoot(value);
                        case "CMtoYards":
                            return CentimeterToYards(value);
                        case "CMtoMiles":
                            return CentimeterToMiles(value);
                        case "MtoCM":
                            return MeterToCentimeter(value);
                        case "MtoKM":
                            return MeterToKilometer(value);
                        case "MtoFoot":
                            return MeterToFoot(value);
                        case "MtoYards":
                            return MeterToYards(value);
                        case "MtoMiles":
                            return MeterToMiles(value);
                        case "KMtoCM":
                            return KilometerToCentimeter(value);
                        case "KMtoM":
                            return KilometerToMeter(value);
                        case "KMtoFoot":
                            return KilometerToFoot(value);
                        case "KMtoYards":
                            return KilometerToYards(value);
                        case "KMtoMiles":
                            return KilometerToMiles(value);
                        default:
                            throw new ArgumentException("Ogiltig enhet");
                    }

                    switch (toSIorUSUnit)
                    {
                        case
                        break;
                    }

                    double CentimeterToMeter(double Centimeter)
                    {
                        return Centimeter / 100;
                    }
                    double CentimeterToKilometer(double Centimeter)
                    {
                        return Centimeter * 100000;
                    }
                    double CentimeterToFoot(double Centimeter)
                    {
                        return Centimeter / 2.54;
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
                        return Miles * 1.60934;
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
                static double ConvertLengthUS(double value, string fromUSUnit, string toUSorSIUnit)
                {
                    switch (fromUSUnit)
                    {
                        case "CMtoM":
                            return CentimeterToMeter(value);
                        case "CMtoKM":
                            return CentimeterToKilometer(value);
                        case "CMtoFoot":
                            return CentimeterToFoot(value);
                        case "CMtoYards":
                            return CentimeterToYards(value);
                        case "CMtoMiles":
                            return CentimeterToMiles(value);
                        case "MtoCM":
                            return MeterToCentimeter(value);
                        case "MtoKM":
                            return MeterToKilometer(value);
                        case "MtoFoot":
                            return MeterToFoot(value);
                        case "MtoYards":
                            return MeterToYards(value);
                        case "MtoMiles":
                            return MeterToMiles(value);
                        case "KMtoCM":
                            return KilometerToCentimeter(value);
                        case "KMtoM":
                            return KilometerToMeter(value);
                        case "KMtoFoot":
                            return KilometerToFoot(value);
                        case "KMtoYards":
                            return KilometerToYards(value);
                        case "KMtoMiles":
                            return KilometerToMiles(value);
                        case "FoottoCM":
                            return FootToCentimeter(value);
                        case "FoottoM":
                            return FootToMeter(value);
                        case "FoottoKM":
                            return FootToKilometer(value);
                        case "FoottoYards":
                            return FootToYards(value);
                        case "FoottoMiles":
                            return FootToMiles(value);
                        case "YardstoCM":
                            return YardsToCentimeter(value);
                        case "YardstoM":
                            return YardsToMeter(value);
                        case "YardstoKM":
                            return YardsToKilometer(value);
                        case "YardstoFoot":
                            return YardsToFoot(value);
                        case "YardstoMiles":
                            return YardsToMiles(value);
                        case "MilestoCM":
                            return MilesToCentimeter(value);
                        case "MilestoM":
                            return MilesToMeter(value);
                        case "MilestoKM":
                            return MilesToKilometer(value);
                        case "MilestoFoot":
                            return MilesToFoot(value);
                        case "Milestoyards":
                            return MilesToYards(value);
                        default:
                            throw new ArgumentException("Ogiltig enhet");
                    }

                    switch (toUSorSIUnit)
                    {
                        case
                        break;
                    }

                    double CentimeterToMeter(double Centimeter)
                    {
                        return Centimeter / 100;
                    }
                    double CentimeterToKilometer(double Centimeter)
                    {
                        return Centimeter * 100000;
                    }
                    double CentimeterToFoot(double Centimeter)
                    {
                        return Centimeter / 2.54;
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
                        return Miles * 1.60934;
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
    }
}
