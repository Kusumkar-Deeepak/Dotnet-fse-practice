using System;

class FinancialForecasting
{
    static double PredictFutureValue(
        double currentValue,
        double growthRate,
        int years)
    {
        // Base Case
        if (years == 0)
        {
            return currentValue;
        }

        // Recursive Case
        return PredictFutureValue(
            currentValue * (1 + growthRate),
            growthRate,
            years - 1);
    }

    static void Main()
    {
        Console.Write("Enter Current Value: ");
        double currentValue =
            Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Growth Rate (%): ");
        double growthRate =
            Convert.ToDouble(Console.ReadLine()) / 100;

        Console.Write("Enter Number of Years: ");
        int years =
            Convert.ToInt32(Console.ReadLine());

        double futureValue =
            PredictFutureValue(
                currentValue,
                growthRate,
                years);

        Console.WriteLine(
            "\nPredicted Future Value: " +
            futureValue.ToString("F2"));
    }
}