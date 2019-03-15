using System;
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
        }
    }

    public class BankAccount
    { 
    private string m_custonerName;

    private double m_balance;
        
    private bool m_frozen = false;

        private BankAccount()
        {
        }

        public BankAccount(string customerName, double balance)
        {
            m_custonerName = customerName;

            m_balance = balance;
        }
        public string CustomerName
        {
            get { return m_custonerName; }
        }

public double Balance
        {
            get { return m_balance; }
        }
        public void Debit(double amount)
        {
            if (m_frozen)
            {
                throw new Exception(("Account frozen");
            }
            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount;
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
