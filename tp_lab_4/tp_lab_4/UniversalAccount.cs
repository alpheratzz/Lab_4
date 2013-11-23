using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_lab_4
{
    abstract class UniversalAccount
    {
        protected double balance;
        protected DateTime start_date;
        //protected int id, pin;
        
        public DateTime StartDate
        {
            get { return start_date; }
        }
        /*public int ID
        {
            get { return id; }
        }*/

        public UniversalAccount()
        {
            balance = 0;
            start_date = DateTime.Now;
        }
        public UniversalAccount(double bal, DateTime date)
        {
            balance = bal;
            start_date = date;
        }

        public abstract double Withdraw(double amount, DateTime paydate);

        public abstract double CheckBalance();

        public void Deposit(double amount)
        {
            balance += amount;
        }
    }
}
