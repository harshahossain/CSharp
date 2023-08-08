using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    internal class SavingAccount:AccountGeneral
    {
        private byte duration;

        internal byte Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
        internal override string Id
        {
            //get { return this.id; }
            set { base.id = value+"-S"; }
        }
        
        public SavingAccount() { }
        public SavingAccount(string name,ulong balance,OurDate openingDate,byte duration):base(name,balance,openingDate)
        {
            this.duration = duration;
        }
        internal override void Withdraw(ulong amount)
            {
                if (this.Balance-amount >=0 && this.Balance>=amount)
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
            Console.WriteLine("Account's Duration : {0}  Year/s [Saving Account]",this.duration);
        }
    }
}
