using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyBankAccount.Elements
{
    public class BankAccount : IBankAccount
    {
        private int _balance;
        public BankAccount(int balance)
        {
            _balance = balance;
        }
        public void Deposit(int amount)
        {
            Console.WriteLine($"the amount of {amount} has been deposited");
            _balance += amount;
        }

        public int GetBalance()
        {
            Console.WriteLine($"you have in your account {_balance}");
            return _balance;
        }

        public bool WithDraw(int amount)
        {
            if(_balance >= amount)
            {
                Console.WriteLine($"the amount of {amount} has been withdrawn");
                _balance -= amount;
                return true;
            }else
            {
                Console.WriteLine("insufficient balance");
                return false;
            }
            
        }
    }
}
