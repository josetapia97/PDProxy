using ProxyBankAccount.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyBankAccount.Proxy
{
    public class BankAccountProxy : IBankAccount
    {
        private BankAccount _bankAccount;
        public BankAccountProxy(BankAccount bankAccount)
        {
            _bankAccount = bankAccount;
        }
        public void Deposit(int amount)
        {
            _bankAccount.Deposit(amount);
        }

        public int GetBalance()
        {
            return _bankAccount.GetBalance();
        }

        public bool WithDraw(int amount)
        {
            if (amount > 100000)
            {
                Console.WriteLine("You need manager approval");
                return false;
            }
            return _bankAccount.WithDraw(amount);
        }
    }
}
