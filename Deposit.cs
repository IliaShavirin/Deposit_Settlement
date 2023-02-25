using System;

namespace Deposit_settlement
{
    internal class Deposit
    {
        private double _contribution;
        private double _interest;
        private double _term;
        protected double Type { get; set; }

        private void WriteDeposit()
        {
            Console.Write("Сумма взноса: ");
            _contribution = double.Parse(Console.ReadLine() ?? string.Empty);
            Console.Write("Под какие проценты: ");
            _interest = double.Parse(Console.ReadLine() ?? string.Empty);
            Console.Write("На какой срок: ");
            _term = double.Parse(Console.ReadLine() ?? string.Empty);
        }

        public double Calculation(int type, double contribution, double interest, double term)
        {
            return contribution * Math.Pow(1 + interest / 100 / type, term);
        }

        private double Calculation()
        {
            return _contribution * Math.Pow(1 + _interest / 100 / Type, _term);
        }
        
        public void Payment()
        {
            WriteDeposit();

            if (_term >= 1 && _term <= Type)
            {
                var total = Calculation();
                Console.WriteLine($"Итоговая сумма: {Math.Round(total, 2)}");
            }
            else
            {
                Console.WriteLine(
                    "Для этого типа капитализации число срока не может быть меньше 1 или больше " + Type);
            }
        }
    }
}