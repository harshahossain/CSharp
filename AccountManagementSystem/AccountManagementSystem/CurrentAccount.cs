using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    internal class CurrentAccount:AccountGeneral
    {
        private string type;
        internal string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public CurrentAccount() { }
        public CurrentAccount(string name,ulong balance,OurDate openingDate,string type):base(name,balance,openingDate)
        {
            this.type = type;
        }
        internal override void Withdraw(ulong amount)
        {
            if (this.Balance-amount >=500 && this.Balance >amount)
             {
                     base.Withdraw(amount);
             }
            else
             {
                    Console.WriteLine("Insufficient Balace!");
                    Console.WriteLine("Current Account Balance is {0} Taka", this.Balance);
             }
 
            
           

        }
        internal override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Account Type: {0}",this.type);
        }
    }
}
