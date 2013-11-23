using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_lab_4
{
    class CheckingAccount : UniversalAccount
    {
        private int monthly_quota;
        private double per_transaction_fee;
        private int total_transactions;
        private DateTime last_validate_date;

        public CheckingAccount() : base()
        {
            monthly_quota = 10;
            per_transaction_fee = 5;
            total_transactions = 0;
            last_validate_date = start_date;
        }

        public CheckingAccount(double bal, DateTime date, int m_quota, double ptf, int total, DateTime lvd)
            : base(bal, date)
        {
            monthly_quota = m_quota;
            per_transaction_fee = ptf;
            total_transactions = total;
            last_validate_date = lvd;
        }

        public int MonthlyQuota
        {
            get { return monthly_quota; }
            set { monthly_quota = value; }
        }
        public double PerTransactionFee
        {
            get { return per_transaction_fee; }
            set { per_transaction_fee = value; }
        }

        private void ValidateTransactionNumber()
        {
            if (last_validate_date.Date != DateTime.Now.Date && DateTime.Now.Day == start_date.Day)
                total_transactions = 0;
            last_validate_date = DateTime.Now;
        }

        public override double CheckBalance()
        {
            Console.WriteLine("Current balance: {0}\n Transactions left: {1}\nFee per transaction: {2}", 
                balance, monthly_quota-total_transactions, per_transaction_fee);
            return balance;
        }

        public override double Withdraw(double amount, DateTime paydate)
        {
            ValidateTransactionNumber();
            double fee = (total_transactions >= monthly_quota)?per_transaction_fee:0f;
            if (amount <= (balance + fee))
            {
                balance -= amount + fee;
                total_transactions++;
                return amount;
            }
            else return 0;
        }
    }
}
