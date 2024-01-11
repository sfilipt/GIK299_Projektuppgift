using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektuppgift
{
    public class Temperatur
    {
        private int menu1Choice = 0;
        private int menu2Choice;
        private double amountToConvert = 0;
        private double answer = 0;
        private string? unit = default;
        private string? outputUnit = default;
        //Strängen docPath anger vart resultetet av konverteringen ska sparas.
        private string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        //Meny som visas om användaren valt att konvertera temperatur
        public void Menu1()
        {
            //Variabler som används för att hantera menyinput och konverteringar
            
            while (menu1Choice != 4)
            {
                Console.WriteLine("\n--------------Temperatur---------------------\n" +
                             "Vilken temperaturenhet vill du konvertera från?" +
                             "\n1. SI-enhet, (Kelvin,K)." +
                             "\n2. Fahrenheit (°F)." +
                             "\n3. Celsius (°C)" +
                             "\n4. Gå tillbaka till föregående meny." +
                             "\n---------------------------------------------\n");
                string? menu1ChoiceInput = Console.ReadLine();
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
                        Console.Clear();
                        break;
                }

             
            }
            //Metod som låter användaren välja vilken enhet som hen vill konvertera till
            void Menu2()
            {
                switch (menu1Choice)
                {
                    case 1:
                        Console.WriteLine("\n-------------------------------" +
                            "\nVilken temperaturenhet vill du konvertera till?" +
                            "\n1. Fahrenheit (°F)." +
                            "\n2. Celsius (°C)" +
                            "\n---------------------------------\n");
                        string? menu2ChoiceInput1 = Console.ReadLine();
                        while (string.IsNullOrWhiteSpace(menu2ChoiceInput1) || !int.TryParse(menu2ChoiceInput1, out menu2Choice) || menu2Choice > 2 || menu2Choice < 1)
                        {
                            Console.WriteLine("Fel: Ange ett tal mellan 1 och 4.");
                            menu2ChoiceInput1 = Console.ReadLine();
                        }
                        if (menu2Choice == 1)
                            outputUnit = "°F";
                        else if (menu2Choice == 2)
                            outputUnit = "°C";
                        ConvertFromSI();
                        Answer();
                        menu1Choice = 0;
                        Console.WriteLine("\n Tryck Enter för att fortsätta programmet");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("\n-------------------------------" +
                            "\nVilken temperaturenhet vill du konvertera till?" +
                            "\n1. SI-enhet (Kelvin,K)." +
                            "\n2. Celsius (°C)" +
                            "\n---------------------------------\n");
                        string? menu2ChoiceInput2 = Console.ReadLine();
                        while (string.IsNullOrWhiteSpace(menu2ChoiceInput2) || !int.TryParse(menu2ChoiceInput2, out menu2Choice) || menu2Choice > 2 || menu2Choice < 1)
                        {
                            Console.WriteLine("Fel: Ange ett tal mellan 1 och 4.");
                            menu2ChoiceInput2 = Console.ReadLine();
                        }
                        if (menu2Choice == 1)
                            outputUnit = "K";
                        else if (menu2Choice == 2)
                            outputUnit = "°C";
                        ConvertFromFahrenheit();
                        Answer();
                        menu1Choice = 0;
                        Console.WriteLine("\n Tryck Enter för att fortsätta programmet");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("\n-------------------------------" +
                            "\nVilken temperaturenhet vill du konvertera till?" +
                            "\n1. SI-enhet (Kelvin,K)." +
                            "\n2. Fahrenheit (°F)." +
                            "\n---------------------------------\n");
                        string? menu2ChoiceInput3 = Console.ReadLine();
                        while (string.IsNullOrWhiteSpace(menu2ChoiceInput3) || !int.TryParse(menu2ChoiceInput3, out menu2Choice) || menu2Choice > 2 || menu2Choice < 1)
                        {
                            Console.WriteLine("Fel: Ange ett tal mellan 1 och 4.");
                            menu2ChoiceInput3 = Console.ReadLine();
                        }
                        if (menu2Choice == 1)
                            outputUnit = "K";
                        else if (menu2Choice == 2)
                            outputUnit = "°F";
                        ConvertFromCelsius();
                        Answer();
                        menu1Choice = 0;
                        Console.WriteLine("\n Tryck Enter för att fortsätta programmet");
                        Console.ReadKey();
                        break;
                }
            }
               
            //Metoder som sköter omvandling mellan olika temperaturenheter

            void ConvertFromSI()
            {
                Console.WriteLine($"\nHur många {unit} vill du omvandla?\n");
                Console.Write("Ange värdet:");
                string? strAmountToConvert = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(strAmountToConvert) || !double.TryParse(strAmountToConvert, out amountToConvert) || amountToConvert < 0)
                {
                    Console.WriteLine("Fel: Ange ett tal som ska konverteras.Talet måste vara större än 0 eftersom 0K är absoluta nollpunkten.");
                    strAmountToConvert = Console.ReadLine();
                }
                switch (outputUnit)
                {
                    case "°F":
                        answer = ((amountToConvert - 273.15) * 1.8) + 32;
                        break;
                    case "°C":
                        answer = (amountToConvert - 273.15);
                        break;
                }
                    
            }
            void ConvertFromFahrenheit()
            {
                Console.WriteLine($"\nHur många {unit} vill du omvandla?\n");
                Console.Write("Ange värdet:");
                string? strAmountToConvert = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(strAmountToConvert) || !double.TryParse(strAmountToConvert, out amountToConvert) || amountToConvert < 0)
                {
                    Console.WriteLine("Fel: Ange ett tal som ska konverteras.Talet måste vara större än 0 eftersom 0K är absoluta nollpunkten.");
                    strAmountToConvert = Console.ReadLine();
                }
                switch (outputUnit)
                {
                    case "K":
                        answer = ((amountToConvert - 32) / 1.8) + 273.15;
                        break;
                    case "°C":
                        answer = (amountToConvert - 32) / 1.8;
                        break;
                }

            }
            void ConvertFromCelsius()
            {
                Console.WriteLine($"\nHur många {unit} vill du omvandla?\n");
                Console.Write("Ange värdet:");
                string? strAmountToConvert = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(strAmountToConvert) || !double.TryParse(strAmountToConvert, out amountToConvert) || amountToConvert < 0)
                {
                    Console.WriteLine("Fel: Ange ett tal som ska konverteras.Talet måste vara större än 0 eftersom 0K är absoluta nollpunkten.");
                    strAmountToConvert = Console.ReadLine();
                }
                switch (outputUnit)
                {
                    case "K":
                        answer = amountToConvert + 273.15;
                        break;
                    case "°F":
                        answer = (amountToConvert * 1.8) + 32;
                        break;
                    case "°C":
                        answer = amountToConvert;
                        break;
                }

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
