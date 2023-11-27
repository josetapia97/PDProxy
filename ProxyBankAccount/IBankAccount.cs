using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyBankAccount
{
    public interface IBankAccount
    {
        void Deposit(int amount);
        bool WithDraw(int amount);
        int GetBalance();
    }
}
