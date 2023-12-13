using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektuppgift
{
    internal class Vikt
    {
        static void Menu1()
        {
            int menuChoice = 0;
            int menuChoice2 = 0;
            int menuChoice3 = 0;
            double answer = 0;
            while (menuChoice != 3)
                Console.WriteLine("\n ---------------------------------\n" +
                             "Vilken enhet vill du konvertera från?" +
                             "\n1. SI-enhet." +
                             "\n2. Amerikansk enheter." +
                             "\n3. Gå tillbaka till föregående meny.");
            menuChoice = Convert.ToInt32(Console.ReadLine());
            switch (menuChoice)
            {
                case 1:
                    Menu2();
                    break;
                case 2:
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
                if (menuChoice2 == 1)
                {
                    Console.WriteLine("Vilket prefix vill du använda?" +
                        "\n 1. Gram" +
                        "\n 2. Kilogram" +
                        "\n 3. Ton");
                    menuChoice3 = Convert.ToInt32(Console.ReadLine());
                }
                if (menuChoice2 == 2)
                {
                    Console.WriteLine("Vilket prefix vill du använda?" +
                        "\n 1. Ounce" +
                        "\n 2. Pound" +
                        "\n 3. Stone");
                    menuChoice3 = Convert.ToInt32(Console.ReadLine());
                }
                if ((menuChoice == 1) && (menuChoice2 == 1))
                    SIToSI();
                if ((menuChoice == 1) && (menuChoice2 == 2))
                    SIToAmerican();
                if ((menuChoice == 2) && (menuChoice2 == 2))
                    AmericanToAmerican();
                if ((menuChoice == 2) && (menuChoice2 == 2))
                    AmericanToSI();
            }
            static void SIToAmerican()
            {

            }
            static void AmericanToSI()
            {

            }
            static void AmericanToAmerican()
            {

            }
            static void SIToSI()
            {

            }
        }
    }
}
