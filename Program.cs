using System;
using System.Collections.Generic;
using SplashKitSDK;

public class Program
{

    private static List<double> _values = new List<double>();

    public enum UserOption
    {
        NewValue,
        Sum,
        Print,
        Quit
    }

    public static int ReadInterger(string prompt)
    {
        while (true)
        {
            try
            {
                return Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("PLease enter a valid interger");
            }
        }
    }

    public static double ReadDouble(string prompt)
    {
        while (true)
        {
            try
            {
                return Double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("PLease enter a valid Double");
            }
        }
    }

    public static void AddValueToList()
    {
       _values.Add(ReadDouble("Enter numbers for list"));
    }

    public static void Print()
    {
        foreach (double number in _values)
        {
            Console.WriteLine(number);
        }
    }

    public static void Sum()
    {
        double sum = 0;

        foreach (double number in _values)
        {
            sum += number;
            Console.WriteLine(sum);
        }
    }

    public static UserOption ReadUserOption()
    {
        Console.WriteLine("Enter 0 to add a value");
        Console.WriteLine("Enter 1 to sum all values");
        Console.WriteLine("Enter 2 to print values");
        Console.WriteLine("Enter 3 to quit");

        int option = 3;
        Int32.TryParse(Console.ReadLine(), out option);

        return(UserOption) option;
    }

    public static void Main()
    {
        do
        {
            switch (ReadUserOption())
            {
                case UserOption.NewValue:
                    AddValueToList();
                    break;
                case UserOption.Sum:
                    Sum();
                    break;
                case UserOption.Print:
                    Print();
                    break;
                case UserOption.Quit:
                    Console.WriteLine("Quitting program");
                    break;
            }
        } while (ReadUserOption() != UserOption.Quit);
    }
}
