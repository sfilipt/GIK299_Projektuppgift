using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektuppgift
{
    public class Temperatur
    {
        //Meny som visas om användaren valt att konvertera temperatur
        public void Menu1()
        {
            int menu1Choice = 0;
            int menu2Choice;
            double amountToConvert = 0;
            double answer = 0;
            string unit = default;
            string outputUnit = default;
            //Strängen docPath anger vart resultetet av konverteringen ska sparas.
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            while (menu1Choice != 4)
            {
                Console.WriteLine("\n-----------------------------------\n" +
                             "Vilken temperaturenhet vill du konvertera från?" +
                             "\n1. SI-enhet, (Kelvin,K)." +
                             "\n2. Fahrenheit (°F)." +
                             "\n3. Celsius (°C)" +
                             "\n4. Gå tillbaka till föregående meny." +
                             "\n---------------------------------\n");
                string menu1ChoiceInput = Console.ReadLine();
                // While-loop som sköter felaktig input från användaren. Denna återanvänds i lite olika utförande för all användarinput.
                while (string.IsNullOrWhiteSpace(menu1ChoiceInput) || !int.TryParse(menu1ChoiceInput, out menu1Choice) || menu1Choice > 4 || menu1Choice < 1)
                {
                    Console.WriteLine("Fel: Skriv in en siffra mellan 1 och 3.");
                    menu1ChoiceInput = Console.ReadLine();
                }
                switch (menu1Choice)
                {
                    case 1:
                        unit = "K";
                        Menu2();
                        break;
                    case 2:
                        unit = "°F";
                        Menu2();
                        break;
                    case 3:
                        unit = "°C";
                        Menu2();
                        break;
                    case 4:
                        break;
                }

             
            }
            //Metod som låter användaren välja vilken enhet som hen vill konvertera till
            void Menu2()
            {
                Console.WriteLine("\n-------------------------------" +
                            "\nVilken temperaturenhet vill du konvertera till?" +
                            "\n1. SI-enhet (Kelvin,K)." +
                            "\n2. Fahrenheit (°F)." +
                            "\n3. Celsius (°C)" +
                            "\n---------------------------------\n");
                string menu2ChoiceInput = Console.ReadLine();
                while (string.IsNullOrWhiteSpace (menu2ChoiceInput) ||!int.TryParse(menu2ChoiceInput, out menu2Choice) || menu2Choice > 3 || menu2Choice < 1)
                { 
                    Console.WriteLine("Fel: Ange ett tal mellan 1 och 4."); 
                    menu2ChoiceInput = Console.ReadLine();
                }
                    switch (menu2Choice)
                {
                    //Kelvin till Kelvin, Fahrenheit till Kelvin, Celsius till Kelvin
                    case 1:
                        if (menu1Choice == 1)
                        {
                            OutputUnit();
                            SIToSI();
                            Answer();
                            menu1Choice = 0;
                            Console.WriteLine("\n Tryck Enter för att fortsätta programmet");
                            Console.ReadKey();
                        }
                        else if (menu1Choice == 2)
                        {
                            OutputUnit();
                            FahrenheitToSI();
                            Answer();
                            menu1Choice = 0;
                            Console.WriteLine("\nTryck Enter för att fortsätta programmet");
                            Console.ReadKey();
                        }
                        else if (menu1Choice == 3)
                        {
                            OutputUnit();
                            CelsiusToSI();
                            Answer();
                            menu1Choice = 0;
                            Console.WriteLine("\n Tryck Enter för att fortsätta programmet");
                            Console.ReadKey();
                        }
                        break;
                    //Kelvin till Fahrenheit, Fahrenheit till Fahrenheit och Celsius till Fahrenheit
                    case 2:
                        if (menu1Choice == 1)
                        {
                            OutputUnit();
                            SIToFahrenheit();
                            Answer();
                            menu1Choice = 0;
                            Console.WriteLine("\nTryck Enter för att fortsätta programmet");
                            Console.ReadKey();
                        }
                        if (menu1Choice == 2)
                        {
                            OutputUnit();
                            FahrenheitToFahrenheit();
                            Answer();
                            menu1Choice = 0;
                            Console.WriteLine("\nTryck Enter för att fortsätta programmet");
                            Console.ReadKey();
                        }
                        if (menu1Choice == 3)
                        {
                            OutputUnit();
                            CelsiusToFahrenheit();
                            Answer();
                            menu1Choice = 0;
                            Console.WriteLine("\nTryck Enter för att fortsätta programmet");
                            Console.ReadKey();
                        }
                        break;
                    //Kelvin till Celsius, Fahrenheit till Celsius och Celsius till Celsius
                    case 3:
                        if (menu1Choice == 1)
                        {
                            OutputUnit();
                            SIToCelsius();
                            Answer();
                            menu1Choice = 0;
                            Console.WriteLine("\nTryck Enter för att fortsätta programmet");
                            Console.ReadKey();
                        }
                        if (menu1Choice == 2)
                        {
                            OutputUnit();
                            FahrenheitToCelsius();
                            Answer();
                            menu1Choice = 0;
                            Console.WriteLine("\nTryck Enter för att fortsätta programmet");
                            Console.ReadKey();
                        }
                        if (menu1Choice == 3)
                        {
                            OutputUnit();
                            CelsiusToCelsius();
                            Answer();
                            menu1Choice = 0;
                            Console.WriteLine("\nTryck Enter för att fortsätta programmet");
                            Console.ReadKey();
                        }
                        break;
                }
            }
            //Metod som bestämmer enhet på outputen
            string OutputUnit()
            {
                if (menu2Choice == 1)
                {
                    outputUnit = "K";
                }
                else if (menu2Choice == 2)
                {
                    outputUnit = "°F";
                }
                else if (menu2Choice == 3)
                {
                    outputUnit = "°C";
                }
                return outputUnit;
            }
            //Metoder som sköter omvandling mellan olika temperaturenheter
            double SIToSI()
            {
                Console.WriteLine($"\n Hur många {unit} vill du omvandla?\n");
                string strAmountToConvert = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(strAmountToConvert) || !double.TryParse(strAmountToConvert, out amountToConvert) || amountToConvert < 0)
                {
                    Console.WriteLine("Fel: Ange ett tal som ska konverteras.Talet måste vara större än 0 eftersom 0K är absoluta nollpunkten.");
                    strAmountToConvert = Console.ReadLine();
                }
                answer = amountToConvert;
                return answer;

            }
            double SIToFahrenheit()
            {
                Console.WriteLine($"\n Hur många {unit} vill du omvandla?\n");
                string strAmountToConvert = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(strAmountToConvert) || !double.TryParse(strAmountToConvert, out amountToConvert) || amountToConvert < 0)
                {
                    Console.WriteLine("Fel:Ange ett tal som ska konverteras.Talet måste vara större än 0 eftersom 0K är absoluta nollpunkten.");
                    strAmountToConvert = Console.ReadLine();
                }
                answer = ((amountToConvert - 273.15)*1.8)+32; 
                return answer;

            }
            double SIToCelsius()
            {
                Console.WriteLine($"\n Hur många {unit} vill du omvandla?\n");
                string strAmountToConvert = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(strAmountToConvert) || !double.TryParse(strAmountToConvert, out amountToConvert) || amountToConvert < 0)
                {
                    Console.WriteLine("Fel: Ange ett tal som ska konverteras.Talet måste vara större än 0 eftersom 0K är absoluta nollpunkten.");
                    strAmountToConvert = Console.ReadLine();
                }
                amountToConvert = double.Parse(Console.ReadLine());
                answer = (amountToConvert - 273.15);
                return answer;

            }
            double FahrenheitToSI()
            {
                Console.WriteLine($"\n Hur många  {unit}  vill du omvandla?\n");
                string strAmountToConvert = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(strAmountToConvert) || !double.TryParse(strAmountToConvert, out amountToConvert) || amountToConvert < -459.67)
                {
                    Console.WriteLine("Fel: Ange ett tal som ska konverteras.Talet måste vara större än -459,67 eftersom -459,67°F är absoluta nollpunkten.");
                    strAmountToConvert = Console.ReadLine();
                }
                amountToConvert = double.Parse(Console.ReadLine());
                answer = ((amountToConvert - 32) / 1.8) + 273.15;
                return answer;

            }
            double FahrenheitToFahrenheit()
            {
                Console.WriteLine($"\n Hur många  {unit}  vill du omvandla?\n");
                string strAmountToConvert = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(strAmountToConvert) || !double.TryParse(strAmountToConvert, out amountToConvert) || amountToConvert < -459.67)
                {
                    Console.WriteLine("Fel: Ange ett tal som ska konverteras.Talet måste vara större än -459,67 eftersom -459,67°F är absoluta nollpunkten.");
                    strAmountToConvert = Console.ReadLine();
                }
                answer = amountToConvert;
                return answer;

            }
            double FahrenheitToCelsius()
            {
                Console.WriteLine($"\n Hur många  {unit}  vill du omvandla?\n");
                string strAmountToConvert = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(strAmountToConvert) || !double.TryParse(strAmountToConvert, out amountToConvert) || amountToConvert < -459.67)
                {
                    Console.WriteLine("Fel: Ange ett tal som ska konverteras.Talet måste vara större än -459,67 eftersom -459,67°F är absoluta nollpunkten.");
                    strAmountToConvert = Console.ReadLine();
                }
                answer = (amountToConvert - 32) / 1.8;
                return answer;

            }
            double CelsiusToSI()
            {
                Console.WriteLine($"\n Hur många  {unit}  vill du omvandla?\n");
                string strAmountToConvert = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(strAmountToConvert) || !double.TryParse(strAmountToConvert, out amountToConvert) || amountToConvert < -273.15)
                {
                    Console.WriteLine("Fel: Ange ett tal som ska konverteras.Talet måste vara större än -273,15 eftersom -273,15°C är absoluta nollpunkten.");
                    strAmountToConvert = Console.ReadLine();
                }
                answer = amountToConvert + 273.15;
                return answer;

            }
            double CelsiusToFahrenheit()
            {
                Console.WriteLine($"\n Hur många  {unit}  vill du omvandla?\n");
                string strAmountToConvert = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(strAmountToConvert) || !double.TryParse(strAmountToConvert, out amountToConvert) || amountToConvert < -273.15)
                {
                    Console.WriteLine("Fel: Ange ett tal som ska konverteras.Talet måste vara större än -273,15 eftersom -273,15°C är absoluta nollpunkten.");
                    strAmountToConvert = Console.ReadLine();
                }
                answer = (amountToConvert * 1.8) + 32;
                return answer;

            }
            double CelsiusToCelsius()
            {
                Console.WriteLine($"\n Hur många  {unit}  vill du omvandla?\n");
                string strAmountToConvert = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(strAmountToConvert) || !double.TryParse(strAmountToConvert, out amountToConvert) || amountToConvert < -273.15)
                {
                    Console.WriteLine("Fel: Ange ett tal som ska konverteras.Talet måste vara större än -273,15 eftersom -273,15°C är absoluta nollpunkten.");
                    strAmountToConvert = Console.ReadLine();
                }
                answer = amountToConvert;
                return answer;

            }
            //Metod som skriver ut svaret i konsolen och sparar resultatet av konverteringen till en fil.
            void Answer()
            {
                answer = Math.Round(answer, 3);
                Console.WriteLine($"\n Svar: {amountToConvert} {unit} är {answer} {outputUnit}\n");
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Resultat.txt"), true))
                {
                    outputFile.WriteLine($"Svar: {amountToConvert} {unit} är {answer} {outputUnit}");
                }
            }
        }
    }
}
