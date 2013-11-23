using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_lab_4
{
    class SavingsAccount : UniversalAccount
    {
        private double interest_rate;
        private DateTime last_accrue_date;

        public double InterestRate
        {
            get { return interest_rate; }
        }

        public SavingsAccount() : base()
        {
            interest_rate = 0.1;
            last_accrue_date = start_date;
        }

        public SavingsAccount(double bal, DateTime date, double int_rate)
            : base(bal, date)
        {
            interest_rate = int_rate;
            last_accrue_date = date;
        }

        public override double CheckBalance()
        {
            AccruePercents();
            Console.WriteLine("Current balance: {0}\n Interest rate: {1}", balance, interest_rate);
            return balance;
        }

        public override double Withdraw(double amount, DateTime paydate)
        {
            AccruePercents();
            if (amount <= balance)
            {
                balance -= amount;
                return amount;
            }
            else return 0f;
        }

        private void AccruePercents()
        {
            int years = (int)Math.Floor(DateTime.Now.Subtract(last_accrue_date).TotalDays / 365.2422);
            for (int i = 1; i <= years; i++)
                balance *= 1 + interest_rate;
            last_accrue_date = last_accrue_date.AddYears(years);
        }
    }
}
