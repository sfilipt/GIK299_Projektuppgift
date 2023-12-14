using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projektuppgift
{
    public class Vikt
    {
        public void Menu1()
        {
            int menu1Choice = 0;
            int menu2Choice = 0;
            int inputPrefix = 0;
            int outputPrefixA = 0;
            int outputPrefixSI = 0;
            double amountToConvert = 0;
            double answer = 0;
            string unit = default;
            string outputPrefix = default;
            while (menu1Choice != 3)
            {
                Console.WriteLine("\n-----------------------------------\n" +
                             "Vilken enhet vill du konvertera från?" +
                             "\n1. SI-enhet." +
                             "\n2. Amerikansk enheter." +
                             "\n3. Gå tillbaka till föregående meny." +
                             "\n---------------------------------\n");
                menu1Choice = Convert.ToInt32(Console.ReadLine());
                switch (menu1Choice)
                {
                    case 1:
                        Console.WriteLine("\n-------------------------------------------\n " +
                            "\nVilket prefix har enheten du vill omvandla från?" +
                            "\n 1. Gram" +
                            "\n 2. Kilogram" +
                            "\n 3. Ton" +
                            "\n -------------------------------------------\n");
                        inputPrefix = Convert.ToInt32(Console.ReadLine());
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
                        break;
                    case 2:
                        Console.WriteLine("\n-------------------------------------------\n " +
                            "\nVilket prefix har enheten du vill omvandla från?" +
                           "\n 1. Ounce" +
                           "\n 2. Pound" +
                           "\n 3. Short ton" +
                           "\n-------------------------------------------\n ");
                        inputPrefix = Convert.ToInt32(Console.ReadLine());
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
                        break;
                    case 3:
                        break;
                }

                void Menu2()
                {
                    Console.WriteLine("\n-------------------------------" +
                                "\nVilken enhet vill du konvertera till?" +
                                "\n1. SI-enhet." +
                                "\n2. Amerikanka enheter" +
                                "\n3. Gå tillbaka till föregående meny." +
                                "\n-------------------------------");
                    menu2Choice = Convert.ToInt32((Console.ReadLine()));
                        switch (menu2Choice)
                        {
                            case 1:
                                if (menu1Choice == 1)
                                {
                                    OutputPrefix();
                                    SIToSI();
                                    Console.Write($"\nSvar: {amountToConvert} {unit} är {answer} {outputPrefix}\n");
                                    menu2Choice = 0;
                                    menu1Choice = 0;
                                Console.WriteLine("\n Tryck Enter för att fortsätta programmet");
                                Console.ReadKey();
                            }
                                else if (menu1Choice == 2)
                                {
                                    OutputPrefix();
                                    AmericanToSI();
                                    Console.Write($"\nSvar: {amountToConvert} {unit} är {answer} {outputPrefix}\n");
                                    menu2Choice = 0;
                                    menu1Choice = 0;
                                    Console.WriteLine("\nTryck Enter för att fortsätta programmet");
                                    Console.ReadKey();
                            }
                            break;
                        case 2:
                            if (menu1Choice == 1)
                                OutputPrefix();
                                SIToAmerican();
                                Console.Write($"\nSvar: {amountToConvert} {unit} är {answer} {outputPrefix}\n");
                                menu2Choice = 0;
                                menu1Choice = 0;
                            Console.WriteLine("\nTryck Enter för att fortsätta programmet");
                                Console.ReadKey();
                            if (menu1Choice == 2)
                                OutputPrefix();
                                AmericanToAmerican();
                                Console.WriteLine($"\n Svar: {amountToConvert} {unit} är {answer} {outputPrefix}\n");
                                menu2Choice = 0;
                                menu1Choice = 0;
                                Console.WriteLine("\nTryck Enter för att fortsätta programmet");
                                Console.ReadKey();
                            break;
                        case 3:
                            break;

                    }
                }
                //-------------Enheter tagna från https://blog.ansi.org/2018/06/us-customary-system-conversion-metric/
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
                        outputPrefixSI = int.Parse(Console.ReadLine());
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
                        outputPrefixA = int.Parse(Console.ReadLine());
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
                double SIToAmerican()
                {
                    Console.WriteLine($"\n Hur många {unit} vill du omvandla?\n");
                    amountToConvert = double.Parse(Console.ReadLine());
                    switch (inputPrefix)
                    {
                        case 1: if (outputPrefixA == 1) //gram till ounce, pound, short ton
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
                        case 2: if (outputPrefixA == 1) //kilogram till ounce, pound, short ton
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
                        case 3: if (outputPrefixA == 1)//ton till ounce, pound short ton
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
                    amountToConvert = double.Parse(Console.ReadLine());
                    switch (inputPrefix)
                    {
                        case 1:
                            if (outputPrefixA == 1) //ounce till gram, kilogram, ton
                            {
                                answer = amountToConvert * 28.35 ;
                            }
                            else if (outputPrefixA == 2)
                            {
                                answer = amountToConvert * 0.02835 ;
                            }
                            else if (outputPrefixA == 3)
                            {
                                answer = amountToConvert * 0.0002835 ;
                            }
                            break;
                        case 2:
                            if (outputPrefixA == 1) //pound till gram, kilogram, ton
                            {
                                answer = amountToConvert * 450 ;
                            }
                            else if (outputPrefixA == 2) 
                            {
                                answer = amountToConvert * 0.45 ;
                            }
                            else if (outputPrefixA == 3) 
                            {
                                answer = amountToConvert * 0.00045 ;
                            }
                            break;
                        case 3:
                            if (outputPrefixA == 1)//short ton till gram, kilogram, ton
                            {
                                answer = amountToConvert * 900000 ;
                            }
                            else if (outputPrefixA == 2)
                            {
                                answer = amountToConvert * 900 ;
                            }
                            else if (outputPrefixA == 3)
                            {
                                answer = amountToConvert * 0.9 ;
                            }
                            break;
                    }
                    return answer;

                }
                double AmericanToAmerican()
                {
                    Console.WriteLine($"\n Hur många  {unit}  vill du omvandla?\n");
                    amountToConvert = double.Parse(Console.ReadLine());
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
                                answer = amountToConvert * 31746.032 ;
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
                    amountToConvert = double.Parse(Console.ReadLine());
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
}

