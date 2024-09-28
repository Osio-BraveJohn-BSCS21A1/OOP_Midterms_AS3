using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class BankAccount 
    {

        private int _accountNumber;
        private int _balance;
        private double _interest;

        public BankAccount(int accountNumber, int balance, double interest)
        {
            this._accountNumber = accountNumber;
            this._balance = balance;
            this._interest = interest;

        }


        public void Deposit(int money)
        {
            this._balance += money;
        }

        public int GetBalance() { return this._balance; }

        public void Withdraw(int amount)
        {
            if (amount <= this._balance)
            {
                this._balance -= amount;
            }
        }

        public void CalculateInterest()
        {
            int interestAmount = (int)(this._balance * this._interest);
            this._balance += interestAmount;
        }

        public BankAccount(int accountNumber, int initialBalance)
        {

            this._accountNumber = accountNumber;
            this._balance = initialBalance;

        }

        public void Withdraw(int amount, bool isOtherBank)
        {
            int penalty = isOtherBank ? 20 : 0;
            this._balance -= (amount + penalty);

        }

    }
}
