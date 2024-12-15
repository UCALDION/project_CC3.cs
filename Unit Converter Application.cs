using System;

class Converter
{
    private double kilometers;
    private double miles;
    private double celsius;
    private double fahrenheit;
    private double usDollars;
    private double philippinePesos;

    public double Kilometers
    {
        get { return kilometers; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Kilometers cannot be negative.");
            }
            else
            {
                kilometers = value;
            }
        }
    }

    public double Miles
    {
        get { return miles; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Miles cannot be negative.");
            }
            else
            {
                miles = value;
            }
        }
    }

    public double Celsius
    {
        get { return celsius; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Celsius cannot be negative.");
            }
            else
            {
                celsius = value;
            }
        }
    }

    public double Fahrenheit
    {
        get { return fahrenheit; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Fahrenheit cannot be negative.");
            }
            else
            {
                fahrenheit = value;
            }
        }
    }

    public double USDollars
    {
        get { return usDollars; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("US Dollars cannot be negative.");
            }
            else
            {
                usDollars = value;
            }
        }
    }

    public double PhilippinePesos
    {
        get { return philippinePesos; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Philippine Pesos cannot be negative.");
            }
            else
            {
                philippinePesos = value;
            }
        }
    }

    public double ConvertKilometersToMiles()
    {
        return Kilometers * 0.621371;
    }

    public double ConvertMilesToKilometers()
    {
        return Miles / 0.621371;
    }

    public double ConvertCelsiusToFahrenheit()
    {
        return (Celsius * 9 / 5) + 32;
    }

    public double ConvertFahrenheitToCelsius()
    {
        return (Fahrenheit - 32) * 5 / 9;
    }

    public double ConvertUSDollarsToPhilippinePesos()
    {
        return USDollars * 54.50; 
    }

    public double ConvertPhilippinePesosToUSDollars()
    {
        return PhilippinePesos / 54.50; 
    }
}

class Program
{
    static void Main(string[] args)
    {
        Converter converter = new Converter();
        bool continueConversion = true;

        while (continueConversion)
        {
            Console.WriteLine("Choose a conversion command:");
            Console.WriteLine("1: Convert Kilometers to Miles");
            Console.WriteLine("2: Convert Miles to Kilometers");
            Console.WriteLine("3: Convert Celsius to Fahrenheit");
            Console.WriteLine("4: Convert Fahrenheit to Celsius");
            Console.WriteLine("5: Convert US Dollars to Philippine Pesos");
            Console.WriteLine("6: Convert Philippine Pesos to US Dollars");
            Console.WriteLine("7: EXIT");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Kilometers: ");
                    converter.Kilometers = double.Parse(Console.ReadLine());
                    Console.WriteLine("Miles: " + converter.ConvertKilometersToMiles());
                    break;

                case "2":
                    Console.Write("Enter Miles: ");
                    converter.Miles = double.Parse(Console.ReadLine());
                    Console.WriteLine("Kilometers: " + converter.ConvertMilesToKilometers());
                    break;

                case "3":
                    Console.Write("Enter Celsius: ");
                    converter.Celsius = double.Parse(Console.ReadLine());
                    Console.WriteLine("Fahrenheit: " + converter.ConvertCelsiusToFahrenheit());
                    break;

                case "4":
                    Console.Write("Enter Fahrenheit: ");
                    converter.Fahrenheit = double.Parse(Console.ReadLine());
                    Console.WriteLine("Celsius: " + converter.ConvertFahrenheitToCelsius());
                    break;

                case "5":
                    Console.Write("Enter US Dollars: ");
                    converter.USDollars = double.Parse(Console.ReadLine());
                    Console.WriteLine("Philippine Pesos: " + converter.ConvertUSDollarsToPhilippinePesos());
                    break;

                case "6":
                    Console.Write("Enter Philippine Pesos: ");
                    converter.PhilippinePesos = double.Parse(Console.ReadLine());
                    Console.WriteLine("US Dollars: " + converter.ConvertPhilippinePesosToUSDollars());
                    break;

                case "7":
                    continueConversion = false;
                    break;

                default:
                    Console.WriteLine("Invalid. Select a another option according to the list only.");
                    break;
            }

            if (continueConversion)
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine("Bye! Thank you");
    }
}
