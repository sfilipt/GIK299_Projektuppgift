using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektuppgift
{
    public class Vikt
    {
        public void Menu1()
        {
            int menuChoice = 0;
            int menuChoice2 = 0;
            int menuChoice3 = 0;
            double amountToConvert = 0;
            double answer = 0;
            string unit = "test";
            string outputUnit = default;
            while (menuChoice != 3)
            {
                Console.WriteLine("\n ---------------------------------\n" +
                             "Vilken enhet vill du konvertera från?" +
                             "\n1. SI-enhet." +
                             "\n2. Amerikansk enheter." +
                             "\n3. Gå tillbaka till föregående meny.");
                menuChoice = Convert.ToInt32(Console.ReadLine());
                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine("Vilket prefix har storheten du vill omvandla från?" +
                            "\n 1. Gram" +
                            "\n 2. Kilogram" +
                            "\n 3. Ton");
                        menuChoice3 = Convert.ToInt32(Console.ReadLine());
                        if (menuChoice3 == 1)
                        {
                            unit = "gram";
                        }
                        else if (menuChoice3 == 2)
                        {
                            unit = "kilogram";
                        }
                        else if (menuChoice3 == 3)
                        {
                            unit = "ton";
                        }
                        Menu2();
                        break;
                    case 2:
                        Console.WriteLine("Vilket prefix har storheten du vill omvandla från?" +
                           "\n 1. Ounce" +
                           "\n 2. Pound" +
                           "\n 3. Stone");
                        menuChoice3 = Convert.ToInt32(Console.ReadLine());
                        if (menuChoice3 == 1)
                        {
                            unit = "ounce";
                        }
                        else if (menuChoice3 == 2)
                        {
                            unit = "pound";
                        }
                        else if (menuChoice3 == 3)
                        {
                            unit = "stone";
                        }
                        break;
                    case 3:
                        break;
                }

                void Menu2()
                {
                    Console.WriteLine("\n -----------------------" +
                                "\nVilken enhet vill du konvertera till?" +
                                "\n1. SI-enhet." +
                                "\n2. Amerikanka enhter" +
                                "\n3. Gå tillbaka till föregående meny.");
                    menuChoice2 = Convert.ToInt32((Console.ReadLine()));
                    switch (menuChoice2)
                    {
                        case 1:
                            if (menuChoice == 1)
                                SIToSI();
                            if (menuChoice == 2)
                                AmericanToSI();
                            break;
                        case 2:
                            if (menuChoice == 1)
                                SIToAmerican();
                            Console.Write($"{amountToConvert} {unit} är {answer} {outputUnit}");
                            if (menuChoice == 2)
                                AmericanToAmerican();
                            break;
                        case 3:
                            break;

                    }
                }
                double SIToAmerican()
                {
                    Console.WriteLine($"Hur många {unit} vill du omvandla?");
                    amountToConvert = double.Parse(Console.ReadLine());
                    if (unit == "gram")
                    {
                        outputUnit = "ounce";
                        answer = amountToConvert * 0.035274;
                    }
                    else if (unit == "kilogram")
                    { 
                        outputUnit = "pound";
                        answer = amountToConvert * 2.2046;
                    }
                    else if (unit == "ton")

                    {
                        outputUnit = "stone";
                        answer = amountToConvert * 157.473;
                    }
                    return answer;

                }
                void AmericanToSI()
                {
                    Console.WriteLine($"Hur många {0} vill du omvandla?", unit);
                    Console.ReadLine();
                }
                void AmericanToAmerican()
                {
                    Console.WriteLine($"Hur många {0} vill du omvandla?", unit);
                    Console.ReadLine();
                }
                void SIToSI()
                {
                    Console.WriteLine($"Hur många {0} vill du omvandla?", unit);
                    Console.ReadLine();
                }
            }
        }
    }
}
