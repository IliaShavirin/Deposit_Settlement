using System;

namespace Deposit_settlement
{
    internal class DailyCapitalization : Deposit
    {
        public DailyCapitalization()
        {
            Type = 365;
        }
    }
}