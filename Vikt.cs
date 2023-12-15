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
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            while (menu1Choice != 3)
            {
                Console.WriteLine("\n-----------------------------------\n" +
                             "Vilken enhet vill du konvertera från?" +
                             "\n1. SI-enhet." +
                             "\n2. Amerikansk enheter." +
                             "\n3. Gå tillbaka till föregående meny." +
                             "\n---------------------------------\n");
                string menu1ChoiceInput = Console.ReadLine();
                while(!int.TryParse(menu1ChoiceInput, out menu1Choice) || menu1Choice > 3 || menu1Choice < 1)
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
                                "\n 1. Gram" +
                                "\n 2. Kilogram" +
                                "\n 3. Ton" +
                                "\n -------------------------------------------\n");
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
                               "\n 1. Ounce" +
                               "\n 2. Pound" +
                               "\n 3. Short ton" +
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
                            "\n2. Amerikanka enheter" +
                            "\n3. Gå tillbaka till föregående meny." +
                            "\n-------------------------------");
                string menu2ChoiceInput = Console.ReadLine();
                while (!int.TryParse(menu2ChoiceInput, out menu2Choice) || menu2Choice > 3 || menu2Choice < 1)
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
                            Console.WriteLine($"\nSvar: {amountToConvert} {unit} är {answer} {outputPrefix}\n");
                            // https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-write-text-to-a-file#example-synchronously-append-text-with-streamwriter
                            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Resultat.txt"), true))
                            {
                                outputFile.WriteLine($"Svar: {amountToConvert} {unit} är {answer} {outputPrefix}");
                            }
                            menu1Choice = 0;
                            Console.WriteLine("\n Tryck Enter för att fortsätta programmet");
                            Console.ReadKey();
                        }
                        else if (menu1Choice == 2)
                        {
                            OutputPrefix();
                            AmericanToSI();
                            Console.WriteLine($"\nSvar: {amountToConvert} {unit} är {answer} {outputPrefix}\n");
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
                            Console.WriteLine($"\nSvar: {amountToConvert} {unit} är {answer} {outputPrefix}\n");
                            menu1Choice = 0;
                            Console.WriteLine("\nTryck Enter för att fortsätta programmet");
                            Console.ReadKey();
                        }
                        else if (menu1Choice == 2)
                        {
                            OutputPrefix();
                            AmericanToAmerican();
                            Console.WriteLine($"\n Svar: {amountToConvert} {unit} är {answer} {outputPrefix}\n");
                            menu1Choice = 0;
                            Console.WriteLine("\nTryck Enter för att fortsätta programmet");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
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
            //-------------Enheter tagna från https://blog.ansi.org/2018/06/us-customary-system-conversion-metric/
            double SIToAmerican()
            {
                Console.WriteLine($"\n Hur många {unit} vill du omvandla?\n");
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
                        }
                        else if (outputPrefixA == 2)
                        {
                            answer = amountToConvert * 450;
                        }
                        else if (outputPrefixA == 3)
                        {
                            answer = amountToConvert * 900000;
                        }
                        break;
                    case 2:
                        if (outputPrefixA == 1) //kilogram till ounce, pound, short ton
                        {
                            answer = amountToConvert * 0.02835;
                        }
                        else if (outputPrefixA == 2) //pound
                        {
                            answer = amountToConvert * 0.45;
                        }
                        else if (outputPrefixA == 3) //short ton
                        {
                            answer = amountToConvert * 900;
                        }
                        break;
                    case 3:
                        if (outputPrefixA == 1)//ton till ounce, pound short ton
                        {
                            answer = amountToConvert * 0.00002835;
                        }
                        else if (outputPrefixA == 2)
                        {
                            answer = amountToConvert * 0.00045;
                        }
                        else if (outputPrefixA == 3)
                        {
                            answer = amountToConvert * 0.9;
                        }
                        break;
                }
                return answer;

            }
            double AmericanToSI()
            {
                Console.WriteLine($"\n Hur många {unit} vill du omvandla?\n");
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
                        }
                        else if (outputPrefixA == 2)
                        {
                            answer = amountToConvert * 0.02835;
                        }
                        else if (outputPrefixA == 3)
                        {
                            answer = amountToConvert * 0.0002835;
                        }
                        break;
                    case 2:
                        if (outputPrefixA == 1) //pound till gram, kilogram, ton
                        {
                            answer = amountToConvert * 450;
                        }
                        else if (outputPrefixA == 2)
                        {
                            answer = amountToConvert * 0.45;
                        }
                        else if (outputPrefixA == 3)
                        {
                            answer = amountToConvert * 0.00045;
                        }
                        break;
                    case 3:
                        if (outputPrefixA == 1)//short ton till gram, kilogram, ton
                        {
                            answer = amountToConvert * 900000;
                        }
                        else if (outputPrefixA == 2)
                        {
                            answer = amountToConvert * 900;
                        }
                        else if (outputPrefixA == 3)
                        {
                            answer = amountToConvert * 0.9;
                        }
                        break;
                }
                return answer;

            }
            double AmericanToAmerican()
            {
                Console.WriteLine($"\n Hur många  {unit}  vill du omvandla?\n");
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
                        }
                        else if (outputPrefixA == 3)
                        {
                            answer = amountToConvert / 31746.032;
                        }
                        break;
                    case 2:
                        if (outputPrefixA == 1) //pound till ounce, pound, short ton
                        {
                            answer = amountToConvert * 15.87;
                        }
                        else if (outputPrefixA == 2)
                        {
                            answer = amountToConvert;
                        }
                        else if (outputPrefixA == 3)
                        {
                            answer = amountToConvert * 20000;
                        }
                        break;
                    case 3:
                        if (outputPrefixA == 1)//short ton till ounce, pound short ton
                        {
                            answer = amountToConvert * 31746.032;
                        }
                        else if (outputPrefixA == 2)
                        {
                            answer = amountToConvert * 2000;
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
                Console.WriteLine($"\n Hur många  {unit}  vill du omvandla?\n");
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
                        }
                        else if (outputPrefixSI == 3)
                        {
                            answer = amountToConvert / 1000000;
                        }
                        break;
                    case 2:
                        if (outputPrefixSI == 1) //kilogram till gram, kilogram, ton
                        {
                            answer = amountToConvert * 1000;
                        }
                        else if (outputPrefixSI == 2)
                        {
                            answer = amountToConvert;
                        }
                        else if (outputPrefixSI == 3)
                        {
                            answer = amountToConvert * 0.001;
                        }
                        break;
                    case 3:
                        if (outputPrefixSI == 1)//ton till gram, kilogram, ton
                        {
                            answer = amountToConvert / 1000000;
                        }
                        else if (outputPrefixSI == 2)
                        {
                            answer = amountToConvert * 1000;
                        }
                        else if (outputPrefixSI == 3)
                        {
                            answer = amountToConvert;
                        }
                        break;
                }
                return answer;

            }
        }
    }  
}

