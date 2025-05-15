using System;

class FinanceCalc
{
    static void Main()
    {
        //menu 1-4
        while (true)
        {
            Console.WriteLine("select an option by selecting a number");
            Console.WriteLine("1. calculate simple intrest");
            Console.WriteLine("2. Calculate Compound Intrest");
            Console.WriteLine("3. Calculate monthly payment");
            Console.WriteLine("4. Exit");

            string input = Console.ReadLine();

            //call functions
            if (input == "1")
            {
                SimpleIntrest();
            }
            else if (input == "2")
            {
                CompoundIntrest();

            }
            else if (input == "3")
            {
                Payment();
            }
            else if (input == "4")
            {
                Console.WriteLine("Exiting......");
                break; //kill loop
            }
            else
            {
                Console.WriteLine("stop trying to break my program");
            }
        }
    }
    static void SimpleIntrest()
    {

        Console.Write("Enter Principal");
        double Principal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Entar rate as a %");
        double Rate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("enter # of years");
        int time = Convert.ToInt32(Console.ReadLine());

        double intrest = Principal * Rate * time / 100;
        Console.WriteLine($"you will pay ={intrest:F2}");

    }

    static void CompoundIntrest()
    {

        Console.Write("Enter Principal");
        double Principal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Entar rate as a %");
        double Rate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("enter # of years");
        int time = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" enter # of times intres is compouded");
        int number = Convert.ToInt32(Console.ReadLine());

        double amount = Principal * Math.Pow(1 + Rate / (100 * number), number * time);
        double interest = amount - Principal;

        Console.WriteLine($"Compound Interest = {interest:F2}");
    }

    static void Payment()
    {

        Console.Write("Enter Principal");
        double Principal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Entar rate as a %");
        double Rate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("enter # of years");
        int time = Convert.ToInt32(Console.ReadLine());

        double monthlyRate = Rate / (12 * 100); // convert to monthly decimal
        int months = time * 12;

        double emi = (Principal * monthlyRate * Math.Pow(1 + monthlyRate, months)) /
                     (Math.Pow(1 + monthlyRate, months) - 1);

        Console.WriteLine($"Monthly Payment (EMI) = {emi:F2}");
    }
}
