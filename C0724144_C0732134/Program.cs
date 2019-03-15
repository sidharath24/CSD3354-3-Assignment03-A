﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0724144_C0732134
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);

            ba.Credit(5.77);

            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
            Console.ReadLine();
        }
    }

    public class BankAccount
    {
        private string m_customerName;
        private double m_balance;
        private bool m_frozen = false;
        public const string DebitAEBM = "debit amount exceeds balance";
        public const string DebitALTZM = "debit amount less han zero";

        private BankAccount()
        {

        }
        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public string CustomerName

        {
            get { return m_customerName; }
        }
        public double Balance
        {
            get { return m_balance; }
        }

        public void Debit(double amount)
        {

            if (m_frozen)

            {
                throw new Exception("Account frozen");

            }

            if (amount > m_balance)

            {
                throw new ArgumentOutOfRangeException("amount", amount, DebitAEBM);

            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount", amount, DebitALTZM);
            }

            m_balance -= amount;

        }

        public void Credit(double amount)
        {
            if (m_frozen)
            {
                throw new Exception("Account frozen");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount;

        }

        private void FreezeAccount()
        {
            m_frozen = true;

        }

        private void unFreezeAccount()
        {
            m_frozen = false;

        }
    }
}
