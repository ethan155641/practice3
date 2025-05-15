using System;
using System.Globalization;

class FinanceCalc
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nSelect an option by entering a number:");
            Console.WriteLine("1. Calculate Simple Interest");
            Console.WriteLine("2. Calculate Compound Interest");
            Console.WriteLine("3. Calculate Monthly Payment");
            Console.WriteLine("4. Exit");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    SimpleInterest();
                    break;
                case "2":
                    CompoundInterest();
                    break;
                case "3":
                    Payment();
                    break;
                case "4":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please enter 1-4.");
                    break;
            }
        }
    }

    static double ReadDouble(string prompt)
    {
        double value;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out value))
                return value;
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static int ReadInt(string prompt)
    {
        int value;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out value))
                return value;
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    static void SimpleInterest()
    {
        double principal = ReadDouble("Enter Principal: ");
        double rate = ReadDouble("Enter Rate as a %: ");
        int time = ReadInt("Enter Number of Years: ");

        double interest = principal * rate * time / 100;
        Console.WriteLine($"You will pay: {interest:F2}");
    }

    static void CompoundInterest()
    {
        double principal = ReadDouble("Enter Principal: ");
        double rate = ReadDouble("Enter Rate as a %: ");
        int time = ReadInt("Enter Number of Years: ");
        int number = ReadInt("Enter Number of Times Interest is Compounded per Year: ");

        double amount = principal * Math.Pow(1 + rate / (100 * number), number * time);
        double interest = amount - principal;

        Console.WriteLine($"Compound Interest: {interest:F2}");
    }

    static void Payment()
    {
        double principal = ReadDouble("Enter Principal: ");
        double rate = ReadDouble("Enter Rate as a %: ");
        int time = ReadInt("Enter Number of Years: ");

        double monthlyRate = rate / (12 * 100);
        int months = time * 12;

        if (monthlyRate == 0)
        {
            double emi = principal / months;
            Console.WriteLine($"Monthly Payment (EMI): {emi:F2}");
        }
        else
        {
            double emi = (principal * monthlyRate * Math.Pow(1 + monthlyRate, months)) /
                         (Math.Pow(1 + monthlyRate, months) - 1);
            Console.WriteLine($"Monthly Payment (EMI): {emi:F2}");
        }
    }
}
