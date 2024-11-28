using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTemperatureAnalysis
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            double[,] temperatures =  {{12,14,17,17.5,20},
                                       {12,15,18.5,22,25},
                                       {8,14,15,17.5,24 },
                                       {16,18,22.5,25,25},
                                       {18,18.5,22,25,25},
                                       {19,19,22.5,25.5,26},
                                       {20,20,25,25,26} };
            Console.WriteLine("The average Temperature was {0}",calculateWeeklyAverage(temperatures));
            printDailyAverages(temperatures);
            printDailyMaximum(temperatures);

        }
        public static double calculateWeeklyAverage(double[,] temperatures)
        {
            double total = 0;
            for (int i = 0; i < temperatures.GetLength(0); i++)
            {
                for (int j = 0; j < temperatures.GetLength(1); j++)
                {
                    total = total + temperatures[i, j];
                }
            }
            return total/temperatures.Length;
        }
        public static void printDailyAverages(double[,] temperatures)
        {
            Console.WriteLine("\nThe Average Daily Temperatures were:");
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            double dailyTotal = 0;
            for (int row = 0; row < temperatures.GetLength(0); row++)
            {
                for (int column = 0; column < temperatures.GetLength(1); column++)
                {
                    dailyTotal = dailyTotal + temperatures[row, column];
                }
                Console.WriteLine(days[row] + ":" + dailyTotal / temperatures.GetLength(1));
                dailyTotal = 0;
            }
            
        }
        public static void printDailyMaximum(double[,] temperatures)
        {
            Console.WriteLine("\nThe Maximum Daily Temperatures were:");
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            double dailyMax = 0;
            for (int row = 0; row < temperatures.GetLength(0); row++)
            {
                for (int column = 0; column < temperatures.GetLength(1); column++)
                {
                    if (temperatures[row, column]>dailyMax)
                    {
                        dailyMax = temperatures[row, column];
                    }
                }
                Console.WriteLine(days[row] + ":" + dailyMax );
                dailyMax = 0;
            }
        }
    }
}
