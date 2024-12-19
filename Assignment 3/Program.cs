using System;

namespace Assignment_3
{
    internal class Program
    {
        #region Q1
        //i cant how to explain iam so sorry
        #endregion
        #region Q2
        //i cant how to explain iam so sorry
        #endregion
        #region Q3
        //static (double, double, double, double) SummationAndSubtraction(double a, double b, double c, double d)
        //{
        //    double sum1 = a + b;
        //    double diff1 = a - b;

        //    double sum2 = c + d;
        //    double diff2 = c - d;

        //    return (sum1, diff1, sum2, diff2);
        //}
        //static void Main()
        //{
        //    Console.Write("fir num: ");
        //    double num1 = double.Parse(Console.ReadLine());

        //    Console.Write("sec num: ");
        //    double num2 = double.Parse(Console.ReadLine());

        //    Console.Write("thi num: ");
        //    double num3 = double.Parse(Console.ReadLine());

        //    Console.Write("four num: ");
        //    double num4 = double.Parse(Console.ReadLine());

        //    (double sum1, double diff1, double sum2, double diff2) = SummationAndSubtraction(num1, num2, num3, num4);

        //    Console.WriteLine($"Sum of first two numbers: {sum1}");
        //    Console.WriteLine($"Difference of first two numbers: {diff1}");
        //    Console.WriteLine($"Sum of next two numbers: {sum2}");
        //    Console.WriteLine($"Difference of next two numbers: {diff2}");
        //}
        #endregion
        #region Q4

        //static void Main()
        //{
        //    Console.Write("Enter a number: ");
        //    int number = int.Parse(Console.ReadLine());

        //    int sumOfDigits = CalculateSumOfDigits(number);

        //    Console.WriteLine($"The sum of the digits of the number {number} is: {sumOfDigits}");
        //}

        //static int CalculateSumOfDigits(int number)
        //{
        //    int sum = 0;

        //    while (number != 0)
        //    {
        //        sum += number % 10;
        //        number /= 10;      
        //    }

        //    return sum;
        //}
        #endregion
        #region Q5
        //static void Main()
        //{
        //    Console.Write("Enter a number: ");
        //    int number = int.Parse(Console.ReadLine());

        //    bool isPrime = IsPrime(number);

        //    if (isPrime)
        //    {
        //        Console.WriteLine($"{number} is a prime number.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{number} is not a prime number.");
        //    }
        //}

        //static bool IsPrime(int number)
        //{
        //    if (number <= 1)
        //    {
        //        return false;
        //    }

        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0)
        //        {
        //            return false; 
        //        }
        //    }


        //    return true;
        //}


        #endregion
        #region Q6


        //static void Main()
        //{
        //    int[] numbers = { 3, 7, 2, 9, 4, 8, 1, 5, 6 };

        //    int minValue = 0;
        //    int maxValue = 0;

        //    MinMaxArray(numbers, ref minValue, ref maxValue);

        //    Console.WriteLine($"Minimum value: {minValue}");
        //    Console.WriteLine($"Maximum value: {maxValue}");
        //}

        //static void MinMaxArray(int[] arr, ref int min, ref int max)
        //{
        //    min = arr[0];
        //    max = arr[0];

        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] < min)
        //        {
        //            min = arr[i];
        //        }
        //        if (arr[i] > max)
        //        {
        //            max = arr[i];
        //        }
        //    }
        //}


        #endregion
    }
}


