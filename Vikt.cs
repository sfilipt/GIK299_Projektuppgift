using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projektuppgift
{
    public class Vikt
    {
        //Meny som visas om användaren har valt att konvertera viktenheter
        public void Menu1()
        {
            int menu1Choice = 0;
            int menu2Choice;
            int inputPrefix;
            int outputPrefixA = 0;
            int outputPrefixSI = 0;
            double amountToConvert;
            double answer = 0;
            string unit = default;
            string outputPrefix = default;
            //Strängen docPath anger vart resultetet av konverteringen ska sparas.
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            while (menu1Choice != 3)
            {
                Console.WriteLine("\n--------------Vikt---------------------\n" +
                             "Vilken enhet vill du konvertera från?" +
                             "\n1. SI-enhet." +
                             "\n2. Amerikansk enheter." +
                             "\n3. Gå tillbaka till föregående meny." +
                             "\n---------------------------------------\n");
                string menu1ChoiceInput = Console.ReadLine();
                // While-loop som sköter felaktig input från användaren. Denna återanvänds i lite olika utförande för all användarinput.
                while (!int.TryParse(menu1ChoiceInput, out menu1Choice) || menu1Choice > 3 || menu1Choice < 1)
                {
                    Console.WriteLine("Felaktig input, skriv in en siffra mellan 1 och 3.");
                    menu1ChoiceInput = Console.ReadLine();
                }
                //Baserat på vilken input som lagrats i menu1Choice frågas användaren efter vilket prefix den vill omvandla från och sedan anropas metoden Menu2 där 
                //användaren anger vilken enhet de vill konvertera till.
                {
                    switch (menu1Choice)
                    {
                        case 1:
                            {
                                Console.WriteLine("\n-------------------------------------------\n " +
                                "\nVilket prefix har enheten du vill omvandla från?" +
                                "\n1. Gram" +
                                "\n2. Kilogram" +
                                "\n3. Ton" +
                                "\n-------------------------------------------\n");
                                string strInputPrefix = Console.ReadLine();
                                while (!int.TryParse(strInputPrefix, out inputPrefix) || inputPrefix > 3 || inputPrefix < 1)
                                {
                                    Console.WriteLine("Felaktig input, ange en siffra mellan 1 och 3.");
                                    strInputPrefix = Console.ReadLine();
                                }
                                if (inputPrefix == 1)
                                {
                                    unit = "gram";
                                }
                                else if (inputPrefix == 2)
                                {
                                    unit = "kilogram";
                                }
                                else if (inputPrefix == 3)
                                {
                                    unit = "ton";
                                }
                                Menu2();
                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("\n-------------------------------------------\n " +
                                "\nVilket prefix har enheten du vill omvandla från?" +
                               "\n1. Ounce" +
                               "\n2. Pound" +
                               "\n3. Short ton" +
                               "\n-------------------------------------------\n ");
                                string strInputPrefix = Console.ReadLine();
                                while (!int.TryParse(strInputPrefix, out inputPrefix) || inputPrefix > 3 || inputPrefix < 1)
                                {
                                    Console.WriteLine("Felaktig input, ange en siffra mellan 1 och 3.");
                                    strInputPrefix = Console.ReadLine();
                                }
                                if (inputPrefix == 1)
                                {
                                    unit = "ounce";
                                }
                                else if (inputPrefix == 2)
                                {
                                    unit = "pound";
                                }
                                else if (inputPrefix == 3)
                                {
                                    unit = "short ton";
                                }
                                Menu2();
                            }
                            break;
                        case 3:
                            break;
                    }
                }
            }
            //Metod som ger användaren en meny att välja vilken enhet som de vill konvertera till
            void Menu2()
            {
                Console.WriteLine("\n-------------------------------" +
                            "\nVilken enhet vill du konvertera till?" +
                            "\n1. SI-enhet." +
                            "\n2. Amerikanka enheter." +
                            "\n-------------------------------");
                string menu2ChoiceInput = Console.ReadLine();
                while (!int.TryParse(menu2ChoiceInput, out menu2Choice) || menu2Choice > 2 || menu2Choice < 1)
                {
                    Console.WriteLine("Fel: Ange en siffra mellan 1 och 3.");
                    menu2ChoiceInput = Console.ReadLine();
                }
                switch (menu2Choice)
                {
                    case 1:
                        if (menu1Choice == 1)
                        {
                            OutputPrefix();
                            SIToSI();
                            Answer();
                            menu1Choice = 0;
                            Console.WriteLine("\n Tryck Enter för att fortsätta programmet");
                            Console.ReadKey();
                        }
                        else if (menu1Choice == 2)
                        {
                            OutputPrefix();
                            AmericanToSI();
                            Answer();
                            menu1Choice = 0;
                            Console.WriteLine("\nTryck Enter för att fortsätta programmet");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        if (menu1Choice == 1)
                        {
                            OutputPrefix();
                            SIToAmerican();
                            Answer();
                            menu1Choice = 0;
                            Console.WriteLine("\nTryck Enter för att fortsätta programmet");
                            Console.ReadKey();
                        }
                        else if (menu1Choice == 2)
                        {
                            OutputPrefix();
                            AmericanToAmerican();
                            Answer();
                            menu1Choice = 0;
                            Console.WriteLine("\nTryck Enter för att fortsätta programmet");
                            Console.ReadKey();
                        }
                        break;
                }
            }
            //Metod som låter användaren välja prefix på outputen
            string OutputPrefix()
            {
                if (menu2Choice == 1)
                {
                    Console.WriteLine("\n-------------------------------------------\n " +
                               "\nVilket prefix ska resultatet av konverteringen ha?" +
                               "\n1. Gram" +
                               "\n2. Kilogram" +
                               "\n3. Ton" +
                               "\n-------------------------------------------\n ");
                    string strOutputPrefixSI = Console.ReadLine();
                    while (!int.TryParse(strOutputPrefixSI, out outputPrefixSI) || outputPrefixSI > 3 || outputPrefixSI < 1)
                    {
                        Console.WriteLine("Felaktig input, skriv in en siffra mellan 1 och 3.");
                        strOutputPrefixSI = Console.ReadLine();
                    }
                    if (outputPrefixSI == 1)
                    {
                        outputPrefix = "gram";
                    }
                    else if (outputPrefixSI == 2)
                    {
                        outputPrefix = "kilogram";
                    }
                    else if (outputPrefixSI == 3)
                    {
                        outputPrefix = "Ton";
                    }
                }
                if (menu2Choice == 2)
                {
                    Console.WriteLine("\n-------------------------------------------\n " +
                               "\nVilket prefix ska resultatet av konverteringen ha?" +
                               "\n1. Ounce" +
                               "\n2. Pound" +
                               "\n3. Short ton" +
                               "\n-------------------------------------------\n ");
                    string strOutputPrefixA = Console.ReadLine();
                    while (!int.TryParse(strOutputPrefixA, out outputPrefixA) || outputPrefixA > 3 || outputPrefixA < 1)
                    {
                        Console.WriteLine("Felaktig input, skriv in en siffra mellan 1 och 3.");
                        strOutputPrefixA = Console.ReadLine();
                    }
                    if (outputPrefixA == 1)
                    {
                        outputPrefix = "ounce";
                    }
                    else if (outputPrefixA == 2)
                    {
                        outputPrefix = "pound";
                    }
                    else if (outputPrefixA == 3)
                    {
                        outputPrefix = "short ton";
                    }
                }
                return outputPrefix;
            }
            //Metoder som utför omvandlingsberäkningar, 
            double SIToAmerican()
            {
                Console.WriteLine($"\nHur många {unit} vill du omvandla?\n");
                Console.Write("Ange värdet:");
                string strAmountToConvert = Console.ReadLine();
                while(!double.TryParse(strAmountToConvert, out amountToConvert) || amountToConvert < 0)
                {
                    Console.WriteLine("Fel: Ange ett tal som är större än 0");
                    strAmountToConvert = Console.ReadLine();
                }
                switch (inputPrefix)
                {
                    case 1:
                        if (outputPrefixA == 1) //gram till ounce, pound, short ton
                        {
                            answer = amountToConvert * 28.35;
                            answer = answer = Math.Round((answer), 5);
                        }
                        else if (outputPrefixA == 2)
                        {
                            answer = amountToConvert * 450;
                            answer = answer = Math.Round((answer), 2);
                        }
                        else if (outputPrefixA == 3)
                        {
                            answer = amountToConvert * 900000;
                            answer = answer = Math.Round((answer), 2);
                        }
                        break;
                    case 2:
                        if (outputPrefixA == 1) //kilogram till ounce, pound, short ton
                        {
                            answer = amountToConvert / 0.02835;
                            answer = answer = Math.Round((answer), 2);
                        }
                        else if (outputPrefixA == 2) //pound
                        {
                            answer = amountToConvert / 0.45;
                            answer = answer = Math.Round((answer), 5);
                        }
                        else if (outputPrefixA == 3) //short ton
                        {
                            answer = amountToConvert / 900;
                            answer = answer = Math.Round((answer), 10);
                        }
                        break;
                    case 3:
                        if (outputPrefixA == 1)//ton till ounce, pound short ton
                        {
                            answer = amountToConvert / 0.00002835;
                            answer = answer = Math.Round((answer), 2);
                        }
                        else if (outputPrefixA == 2)
                        {
                            answer = amountToConvert / 0.00045;
                            answer = answer = Math.Round((answer), 2);
                        }
                        else if (outputPrefixA == 3)
                        {
                            answer = amountToConvert / 0.9;
                            answer = answer = Math.Round((answer), 2);
                        }
                        break;
                }
                return answer;

            }
            double AmericanToSI()
            {
                Console.WriteLine($"\nHur många {unit} vill du omvandla?\n");
                Console.Write("Ange värdet:");
                string strAmountToConvert = Console.ReadLine();
                while (!double.TryParse(strAmountToConvert, out amountToConvert) || amountToConvert < 0)
                {
                    Console.WriteLine("Fel: Ange ett tal som är större än 0");
                    strAmountToConvert = Console.ReadLine();
                }
                switch (inputPrefix)
                {
                    case 1:
                        if (outputPrefixA == 1) //ounce till gram, kilogram, ton
                        {
                            answer = amountToConvert * 28.35;
                            answer = answer = Math.Round((answer), 2);
                        }
                        else if (outputPrefixA == 2)
                        {
                            answer = amountToConvert * 0.02835;
                            answer = answer = Math.Round((answer), 5);
                        }
                        else if (outputPrefixA == 3)
                        {
                            answer = amountToConvert * 0.0002835;
                            answer = answer = Math.Round((answer), 10);
                        }
                        break;
                    case 2:
                        if (outputPrefixA == 1) //pound till gram, kilogram, ton
                        {
                            answer = amountToConvert * 450;
                            answer = answer = Math.Round((answer), 2);
                        }
                        else if (outputPrefixA == 2)
                        {
                            answer = amountToConvert * 0.45;
                            answer = answer = Math.Round((answer), 5);
                        }
                        else if (outputPrefixA == 3)
                        {
                            answer = amountToConvert * 0.00045;
                            answer = answer = Math.Round((answer), 10);
                        }
                        break;
                    case 3:
                        if (outputPrefixA == 1)//short ton till gram, kilogram, ton
                        {
                            answer = amountToConvert * 900000;
                            answer = answer = Math.Round((answer), 2);
                        }
                        else if (outputPrefixA == 2)
                        {
                            answer = amountToConvert * 900;
                            answer = answer = Math.Round((answer), 2);
                        }
                        else if (outputPrefixA == 3)
                        {
                            answer = amountToConvert * 0.9;
                            answer = answer = Math.Round((answer), 5);
                        }
                        break;
                }
                return answer;

            }
            double AmericanToAmerican()
            {
                Console.WriteLine($"\nHur många  {unit}  vill du omvandla?\n");
                Console.Write("Ange värdet:");
                string strAmountToConvert = Console.ReadLine();
                while (!double.TryParse(strAmountToConvert, out amountToConvert) || amountToConvert < 0)
                {
                    Console.WriteLine("Fel: Ange ett tal som är större än 0");
                    strAmountToConvert = Console.ReadLine();
                }
                switch (inputPrefix)
                {
                    case 1:
                        if (outputPrefixA == 1) //ounce till ounce, pound, short ton
                        {
                            answer = amountToConvert;
                        }
                        else if (outputPrefixA == 2)
                        {
                            answer = amountToConvert / 15.87;
                            answer = answer = Math.Round((answer), 5);
                        }
                        else if (outputPrefixA == 3)
                        {
                            answer = amountToConvert / 31746.032;
                            answer = answer = Math.Round((answer), 10);
                        }
                        break;
                    case 2:
                        if (outputPrefixA == 1) //pound till ounce, pound, short ton
                        {
                            answer = amountToConvert * 15.87;
                            answer = answer = Math.Round((answer), 2);
                        }
                        else if (outputPrefixA == 2)
                        {
                            answer = amountToConvert;
                        }
                        else if (outputPrefixA == 3)
                        {
                            answer = amountToConvert / 20000;
                            answer = answer = Math.Round((answer), 10);
                        }
                        break;
                    case 3:
                        if (outputPrefixA == 1)//short ton till ounce, pound short ton
                        {
                            answer = amountToConvert * 31746.032;
                            answer = answer = Math.Round((answer), 2);
                        }
                        else if (outputPrefixA == 2)
                        {
                            answer = amountToConvert * 2000;
                            answer = answer = Math.Round((answer), 5);
                        }
                        else if (outputPrefixA == 3)
                        {
                            answer = amountToConvert;
                        }
                        break;
                }
                return answer;

            }
            double SIToSI()
            {
                Console.WriteLine($"\nHur många  {unit}  vill du omvandla?\n");
                Console.Write("Ange värdet:");
                string strAmountToConvert = Console.ReadLine();
                while (!double.TryParse(strAmountToConvert, out amountToConvert) || amountToConvert < 0)
                {
                    Console.WriteLine("Fel: Ange ett tal som är större än 0");
                    strAmountToConvert = Console.ReadLine();
                }
                switch (inputPrefix)
                {
                    case 1:
                        if (outputPrefixSI == 1) //gram till gram, kilogram, ton
                        {
                            answer = amountToConvert;
                        }
                        else if (outputPrefixSI == 2)
                        {
                            answer = amountToConvert / 1000;
                            answer = answer = Math.Round((answer), 5);
                        }
                        else if (outputPrefixSI == 3)
                        {
                            answer = amountToConvert / 1000000;
                            answer = answer = Math.Round((answer), 10);
                        }
                        break;
                    case 2:
                        if (outputPrefixSI == 1) //kilogram till gram, kilogram, ton
                        {
                            answer = amountToConvert * 1000;
                            answer = answer = Math.Round((answer), 2);
                        }
                        else if (outputPrefixSI == 2)
                        {
                            answer = amountToConvert;
                        }
                        else if (outputPrefixSI == 3)
                        {
                            answer = amountToConvert * 0.001;
                            answer = answer = Math.Round((answer), 5);
                        }
                        break;
                    case 3:
                        if (outputPrefixSI == 1)//ton till gram, kilogram, ton
                        {
                            answer = amountToConvert / 1000000;
                            answer = answer = Math.Round((answer), 2);
                        }
                        else if (outputPrefixSI == 2)
                        {
                            answer = amountToConvert * 1000;
                            answer = answer = Math.Round((answer), 5);
                        }
                        else if (outputPrefixSI == 3)
                        {
                            answer = amountToConvert;
                        }
                        break;
                }
                return answer;

            }
            //Metod som skriver ut svaret i konsolen och sparar resultatet av konverteringen till en fil.
            void Answer()
            {

                Console.WriteLine($"\n Svar: {amountToConvert} {unit} är {answer} {outputPrefix}\n");
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Resultat.txt"), true))
                {
                    outputFile.WriteLine($"Svar: {amountToConvert} {unit} är {answer} {outputPrefix}");
                }
            }
        }
    }  
}

