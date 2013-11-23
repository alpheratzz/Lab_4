using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_lab_4
{
    class TimedMaturityAccount : SavingsAccount
    {
        private double penalty_rate;

        public double PenaltyRate
        {
            get { return penalty_rate; }
            set { penalty_rate = value; }
        }

        public TimedMaturityAccount() : base()
        {
            penalty_rate = 0.02;
        }

        public TimedMaturityAccount(double bal, DateTime date, double int_rate, double pen_rate)
            : base(bal, date, int_rate)
        {
            penalty_rate = pen_rate;
        }

        public override double CheckBalance()
        {
            Console.WriteLine("Current balance: {0}\n Penalty rate: {1}", balance, penalty_rate);
            return balance;
        }

        public override double Withdraw(double amount, DateTime paydate)
        {
            if (amount <= balance)
            {
                balance -= amount;
                if (DateTime.Now.CompareTo(paydate) < 0)
                    return amount * (1 - penalty_rate);
                else return amount;
            }
            else return 0;
        }
    }
}
