using ProxyBankAccount.Elements;
using ProxyBankAccount.Proxy;

BankAccount myAccount = new BankAccount(1500);
myAccount.Deposit(500);
myAccount.GetBalance();
myAccount.WithDraw(700);
myAccount.GetBalance();
myAccount.Deposit(1000);
myAccount.GetBalance();
myAccount.Deposit(1000000);
myAccount.WithDraw(150000); //esto no se deberia poder hacer

BankAccountProxy cuentaSegura = new BankAccountProxy(myAccount);
cuentaSegura.Deposit(500000);
cuentaSegura.GetBalance();
cuentaSegura.WithDraw(150000);