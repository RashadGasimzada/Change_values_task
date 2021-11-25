using System;

namespace Change_values_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue = 15;
            int secondValue = 25;

            firstValue = firstValue + secondValue;
            secondValue = firstValue + secondValue;
            firstValue = secondValue - firstValue;
            secondValue = secondValue - firstValue * 2;

            Console.WriteLine(firstValue + " " + secondValue);
            Console.ReadLine();

        }
    }
}
