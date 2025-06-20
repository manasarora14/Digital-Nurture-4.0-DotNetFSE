using System;
using System.Collections.Generic;

class Program
{
    // Recursive method to calculate future value
    static double ForecastRecursive(double presentValue, double rate, int years)
    {
        if (years == 0)
            return presentValue;

        return (1 + rate) * ForecastRecursive(presentValue, rate, years - 1);
    }

    // Optimized version using memoization
    static double ForecastMemo(double presentValue, double rate, int years, Dictionary<int, double> memo)
    {
        if (years == 0)
            return presentValue;

        if (memo.ContainsKey(years))
            return memo[years];

        double future = (1 + rate) * ForecastMemo(presentValue, rate, years - 1, memo);
        memo[years] = future;
        return future;
    }

    static void Main()
    {
        double presentValue = 10000;
        double growthRate = 0.10; // 10%
        int years = 5;

        Console.WriteLine("📈 Recursive Forecast:");
        Console.WriteLine($"Future Value (Year {years}): ₹{ForecastRecursive(presentValue, growthRate, years):F2}");

        Console.WriteLine("\n⚡ Optimized Forecast (Memoized):");
        var memo = new Dictionary<int, double>();
        Console.WriteLine($"Future Value (Year {years}): ₹{ForecastMemo(presentValue, growthRate, years, memo):F2}");
    }
}
