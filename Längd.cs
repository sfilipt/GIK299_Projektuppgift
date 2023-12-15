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
        public void LengthConv()
        {
            bool validInput = false;
            bool menu1 = false;
            bool menu2 = false;
            int menuLength = 0;
            int SImenuFrom = 0;
            int SImenuTo = 0;
            int USmenuFrom = 0;
            int USmenuTo = 0;
            while (menuLength != 3)
            {
                Console.WriteLine(
                    "----------Längd----------" +
                    "\nVilken enhet vill du konvertera från?" +
                    "\n1.SI-enheter" +
                    "\n2.Amerikanska enheter" +
                    "\n3.Avsluta längd konverteraren" +
                    "\n-----------------------\n"
                    );

                Console.Write("Enter your choice: ");
                menuLength = Convert.ToInt32(Console.ReadLine());

                switch (menuLength)
                {
                    case 1:
                        LengthConvSI();
                        break;
                    case 2:
                        LengthConvAmerican();
                        break;
                    case 3:
                        break;
                    default: Console.WriteLine("Ogiltigt val. Försök igen. ");
                        break;
                }

                void LengthConvSI()
                {
                    string fromUnit = default;
                    string toUnit = default;
                    while (!validInput)
                    {
                        try
                        {
                            while (menu1)
                            {
                                Console.WriteLine(
                                    "-------------------------" +
                                    "\nVilken prefix har enheten som du vill konvertera från?" +
                                    "\n1.cm" +
                                    "\n2.m" +
                                    "\n3.km" +
                                    "\n4.Gå tillbaka till förra menyn" +
                                    "\n-----------------------\n"
                                    );

                                Console.Write("Ange ditt val: ");
                                SImenuFrom = Convert.ToInt32(Console.ReadLine());

                                switch (SImenuFrom)
                                {
                                    case 1:
                                        fromUnit = "cm";
                                        break;
                                    case 2:
                                        fromUnit = "m";
                                        break;
                                    case 3:
                                        fromUnit = "km";
                                        break;
                                    case 4:
                                        break;
                                    default:
                                        Console.WriteLine("Ogiltigt val. Försök igen. ");
                                        break;
                                }
                            }

                            Console.WriteLine("Ange värdet: ");
                            double value;
                            double convertedValue = ConvertLength(value, fromUnit, toUnit);

                            while (menu2)
                            {
                                Console.WriteLine(
                                    "-------------------------" +
                                    "\nVilken prefix har enheten som du vill konvertera till?" +
                                    "\n1.cm" +
                                    "\n2.m" +
                                    "\n3.km" +
                                    "\n4.Feet" + 
                                    "\n5.Yards" +
                                    "\n6.Miles" +
                                    "\n7.Gå tillbaka till förra menyn" +
                                    "\n-----------------------\n"
                                    );

                                Console.Write("Ange ditt val: ");
                                SImenuTo = Convert.ToInt32(Console.ReadLine());

                                switch (SImenuTo)
                                {
                                    case 1:
                                        toUnit = "cm";
                                        break;
                                    case 2:
                                        toUnit = "m";
                                        break;
                                    case 3:
                                        toUnit = "km";
                                        break;
                                    case 4:
                                        toUnit = "Feet";
                                        break;
                                    case 5:
                                        toUnit = "Yards";
                                        break;
                                    case 6:
                                        toUnit = "Miles";
                                        break;
                                    case 7:
                                        break;
                                    default:
                                        Console.WriteLine("Ogiltigt val. Försök igen. ");
                                        break;
                                }
                                

                                Console.WriteLine($"{value} {fromUnit} motsvarar {convertedValue} {toUnit}");
                            }

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Incorrect format. Please try again. ");
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Invalid input. Please try again. ");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Something went wrong. Please try again. ");
                        }
                    }

                    //Console.WriteLine("Välj enhet att konvertera från (cm, m, km): ");
                    //string fromUnit = Console.ReadLine() ?? "";
                    //
                    //Console.WriteLine("Ange värdet: ");
                    //double value;
                    //
                    //while (!double.TryParse(Console.ReadLine(), out value))
                    //{
                    //    Console.WriteLine("Ogiltig inmatning. Försök igen. ");
                    //}
                    //
                    //Console.WriteLine("Välj enhet att konvertera till (cm, m, km, feet, yards, miles): ");
                    //string toUnit = Console.ReadLine() ?? "";
                    //
                    //double convertedValue = ConvertLength(value, fromUnit, toUnit);
                    //
                    //Console.WriteLine($"{value} {fromUnit} motsvarar {convertedValue} {toUnit}");
                    //
                    //while (!double.TryParse(Console.ReadLine(), out value))
                    //{
                    //    Console.WriteLine("Ogiltig inmatning. Försök igen. ");
                    //}
                    //
                    //Console.WriteLine("Vill du göra en annan konvertering? (ja/nej): ");
                    //string anotherConversion = Console.ReadLine()?.ToLower() ?? "";
                    //
                    //if (anotherConversion == "ja")
                    //{
                    //    LengthConvSI();
                    //}
                    //
                    //else 
                    //{
                    //    Environment.Exit(0);
                    //}
                }

                void LengthConvAmerican()
                {
                    string fromUnit = default;
                    string toUnit = default;
                    while (!validInput)
                    {
                        try
                        {

                            while (menu1)
                            {
                                Console.WriteLine(
                                    "-------------------------" +
                                    "\nVilken prefix har enheten som du vill konvertera från?" +
                                    "\n1.foot" +
                                    "\n2.yards" +
                                    "\n3.miles" +
                                    "\n4.Gå tillbaka till förra menyn" +
                                    "\n-----------------------\n"
                                    );

                                Console.Write("Ange ditt val: ");
                                USmenuFrom = Convert.ToInt32(Console.ReadLine());

                                switch (USmenuFrom)
                                {
                                    case 1:
                                        fromUnit = "foot";
                                        break;
                                    case 2:
                                        fromUnit = "yards";
                                        break;
                                    case 3:
                                        fromUnit = "miles";
                                        break;
                                    case 4:
                                        break;
                                    default:
                                        Console.WriteLine("Ogiltigt val. Försök igen. ");
                                        break;
                                }
                            }

                            Console.WriteLine("Ange värdet: ");
                            double value;

                            double convertedValue = ConvertLength(value, fromUnit, toUnit);
                
                            while (menu2)
                            {
                                Console.WriteLine(
                                    "-------------------------" +
                                    "\nVilken prefix har enheten som du vill konvertera till?" +
                                    "\n1.cm" +
                                    "\n2.m" +
                                    "\n3.km" +
                                    "\n4.Feet" +
                                    "\n5.Yards" +
                                    "\n6.Miles" +
                                    "\n7.Gå tillbaka till förra menyn" +
                                    "\n-----------------------\n"
                                    );

                                Console.Write("Ange ditt val: ");
                                USmenuTo = Convert.ToInt32(Console.ReadLine());

                                switch (USmenuTo)
                                {
                                    case 1:
                                        toUnit = "cm";
                                        break;
                                    case 2:
                                        toUnit = "m";
                                        break;
                                    case 3:
                                        toUnit = "km";
                                        break;
                                    case 4:
                                        toUnit = "Feet";
                                        break;
                                    case 5:
                                        toUnit = "Yards";
                                        break;
                                    case 6:
                                        toUnit = "Miles";
                                        break;
                                    case 7:
                                        break;
                                    default:
                                        Console.WriteLine("Ogiltigt val. Försök igen. ");
                                        break;
                                }
                                Console.WriteLine($"{value} {fromUnit} motsvarar {convertedValue} {toUnit}");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Incorrect format. Please try again. ");
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Invalid input. Please try again. ");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Something went wrong. Please try again. ");
                        }
                    }
                    //Console.WriteLine("Välj enhet att konvertera från (feet, yards, miles): ");
                    //string fromUnit = Console.ReadLine() ?? "";
                    //
                    //Console.WriteLine("Ange värdet: ");
                    //double value;
                    //
                    //while (!double.TryParse(Console.ReadLine(), out value))
                    //{
                    //    Console.WriteLine("Ogiltig inmatning. Försök igen. ");
                    //}
                    //
                    //Console.WriteLine("Välj enhet att konvertera till (cm, m, km, feet, yards, miles): ");
                    //string toUnit = Console.ReadLine() ?? "";
                    //
                    //double convertedValue = ConvertLength(value, fromUnit, toUnit);
                    //
                    //Console.WriteLine($"{value} {fromUnit} motsvarar {convertedValue} {toUnit}");
                    //
                    //while (!double.TryParse(Console.ReadLine(), out value))
                    //{
                    //    Console.WriteLine("Ogiltig inmatning. Försök igen. ");
                    //}
                    //
                    //Console.WriteLine("Tryck Enter för att fortsätta programmet ");
                    //Console.ReadKey();
                }

                double ConvertLength(double value, string fromUnit, string toUnit)
                {
                    switch (fromUnit.ToLower())
                    {
                        case "cm":
                            switch (toUnit.ToLower())
                            {
                                case "cm":
                                    return value;
                                case "m":
                                    return CentimeterToMeter(value);
                                case "km":
                                    return CentimeterToKilometer(value);
                                case "feet":
                                    return CentimeterToFoot(value);
                                case "yards":
                                    return CentimeterToYards(value);
                                case "miles":
                                    return CentimeterToMiles(value);
                                default:
                                    throw new ArgumentException("Ogiltig enhet");
                            }
                        case "m":
                            switch (toUnit.ToLower())
                            {
                                case "cm":
                                    return MeterToCentimeter(value);
                                case "m":
                                    return value;
                                case "km":
                                    return MeterToKilometer(value);
                                case "feet":
                                    return MeterToFoot(value);
                                case "yards":
                                    return MeterToYards(value);
                                case "miles":
                                    return MeterToMiles(value);
                                default:
                                    throw new ArgumentException("Ogiltig enhet");
                            }
                        case "km":
                            switch (toUnit.ToLower())
                            {
                                case "cm":
                                    return KilometerToCentimeter(value);
                                case "m":
                                    return KilometerToMeter(value);
                                case "km":
                                    return value;
                                case "feet":
                                    return KilometerToFoot(value);
                                case "yards":
                                    return KilometerToYards(value);
                                case "miles":
                                    return KilometerToMiles(value);
                                default:
                                    throw new ArgumentException("Ogiltig enhet");
                            }
                        case "feet":
                            switch (toUnit.ToLower())
                            {
                                case "cm":
                                    return FootToCentimeter(value);
                                case "m":
                                    return FootToMeter(value);
                                case "km":
                                    return FootToKilometer(value);
                                case "feet":
                                    return value;
                                case "yards":
                                    return FootToYards(value);
                                case "miles":
                                    return FootToMiles(value);
                                default:
                                    throw new ArgumentException("Ogiltig enhet");
                            }
                        case "yards":
                            switch (toUnit.ToLower())
                            {
                                case "cm":
                                    return YardsToCentimeter(value);
                                case "m":
                                    return YardsToMeter(value);
                                case "km":
                                    return YardsToKilometer(value);
                                case "feet":
                                    return YardsToFoot(value);
                                case "yards":
                                    return value;
                                case "miles":
                                    return YardsToMiles(value);
                                default:
                                    throw new ArgumentException("Ogiltig enhet");
                            }
                        case "miles":
                            switch (toUnit.ToLower())
                            {
                                case "cm":
                                    return MilesToCentimeter(value);
                                case "m":
                                    return MilesToMeter(value);
                                case "km":
                                    return MilesToKilometer(value);
                                case "feet":
                                    return MilesToFoot(value);
                                case "yards":
                                    return MilesToYards(value);
                                case "miles":
                                    return value;
                                default:
                                    throw new ArgumentException("Ogiltig enhet");
                            }
                        default:
                            throw new ArgumentException("Ogiltig enhet");
                    }
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
