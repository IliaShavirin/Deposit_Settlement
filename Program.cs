using System;

namespace Deposit_settlement
{
    internal abstract class Program
    {
        private static void Main(string[] args)
        {
            var depositCalculation = new DepositCalculation();
            var daily = new DailyCapitalization();
            var monthly = new MonthlyCapitalization();
            var quartertly = new QuarterlyCapitalization();

            Console.WriteLine(
                "Выберите тип капитализации: \n 1. Ежедневная капитализация \n 2. Ежемесячная капитализация \n 3. Ежеквартальная капитализация");
            var typeOfCapitalization = Console.ReadLine();

            switch (typeOfCapitalization)
            {
                case "1":
                    depositCalculation.Payment(daily);
                    break;
                case "2":
                    depositCalculation.Payment(monthly);
                    break;
                case "3":
                    depositCalculation.Payment(quartertly);
                    break;
                default:
                    Console.WriteLine("Error! Incorrect type of capitalization!");
                    break;
            }

            Console.ReadKey();
        }
    }
}