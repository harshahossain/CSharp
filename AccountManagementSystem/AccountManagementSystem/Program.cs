using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount savingAccount1 = new SavingAccount("Abid Ali",150000,new OurDate(12,"August",2020),2);
            CurrentAccount currentAccount1 = new CurrentAccount("MD. Bodruzzaman",25000, new OurDate(8,"December",2019),"Salary" );
            savingAccount1.ShowInfo();
            savingAccount1.Withdraw(100000);
            savingAccount1.Withdraw(50000);
            savingAccount1.Withdraw(2);
            savingAccount1.Deposit(2);
            savingAccount1.Deposit(2000);
            currentAccount1.ShowInfo();
            currentAccount1.Withdraw(24000);
            currentAccount1.Withdraw(500);
            currentAccount1.Withdraw(200);
            currentAccount1.Deposit(200);
            currentAccount1.Deposit(4000);

            AccountGeneral[] accounts = new AccountGeneral[3];
            

            Bank b = new Bank();
            b.AddAccount(new SavingAccount("Bruce", 150000, new OurDate(14, "March", 2020), 2));
            b.AddAccount(new CurrentAccount("Kayn", 25000, new OurDate(14, "March", 2020), "Salary"));
            b.AddAccount(new SavingAccount("Diana", 20000, new OurDate(14, "March", 2020), 2));

        }
    }
}
