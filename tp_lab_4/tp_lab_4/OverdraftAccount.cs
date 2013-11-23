using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_lab_4
{
    class OverdraftAccount : UniversalAccount
    {
        private double interest_rate;
        private DateTime last_accrue_date;

        public OverdraftAccount()
            : base()
        {
            interest_rate = 0.05;
            last_accrue_date = start_date;
        }

        public OverdraftAccount(double bal, DateTime date, double int_rate, DateTime last_acc_date)
            : base(bal, date)
        {
            interest_rate = int_rate;
            last_accrue_date = last_acc_date;
        }

        public double InterestRate
        {
            get { return interest_rate; }
        }

        public override double CheckBalance()
        {
            AccruePercents();
            Console.WriteLine("Current balance: {0}\n Interest rate: {1}", balance, interest_rate);
            return balance;
        }

        public override double Withdraw(double amount, DateTime paydate)
        {
            balance -= amount;
            AccruePercents();
            return amount;
        }

        private void AccruePercents()
        {
            int months = (int)Math.Floor(DateTime.Now.Subtract(last_accrue_date).TotalDays / 30);
            for (int i = 0; i < months; i++)
                if (balance < 0)
                    balance *= 1 + interest_rate;
            last_accrue_date = last_accrue_date.AddDays(30 * months);
        }
    }
}
