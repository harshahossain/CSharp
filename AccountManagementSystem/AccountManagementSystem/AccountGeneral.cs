using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    public struct OurDate
    {
        private byte day;
        private string month;
        private ushort year;

        public OurDate(byte day, string month, ushort year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        internal byte Day
        {
            get { return this.day; }
            set {this.day=value ;}
        }
        internal string Month
        {
            get { return this.month; }
            set { this.month = value; }
        }
        internal ushort Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        public void PrintDate()
        {
            Console.WriteLine("Account Openning Date: {0}, {1}, {2}",this.day,this.month,this.year);
        }
    }

    internal class AccountGeneral
    {
        private static int serialNo=0;
        private string name;
        protected string id;
        private ulong balance;
        private OurDate openingDate;

        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        internal virtual string Id
        {
            get { return this.id; }
            set { this.id = "A-"+value; }
        }
        internal ulong Balance
        {
            get { return this.balance; }
            set { this.balance = value; }

        }
        internal OurDate OpeningDate
        {
            get { return this.openingDate; }
            set { this.openingDate = value; }
        }
        internal AccountGeneral() { }

        internal AccountGeneral(string name,ulong balance, OurDate openingDate)
        {
            this.name = name;
            this.id = (++serialNo).ToString();
            this.balance = balance;
            this.openingDate = openingDate;
 
        }
        internal virtual void Withdraw(ulong amount)
        {
            
            
                this.Balance -= amount;
                Console.WriteLine("{0} Taka Withdrew Successfuly", amount);
                Console.WriteLine("Current Account Balance is {0} Taka", this.Balance);
            }
            
        internal virtual void Deposit(ushort amount)
        {
            ushort minAmount = 499;
            if (amount > minAmount)
            {
                this.Balance += amount;
                Console.WriteLine("{0} Taka Deposited Successfully", amount);
                Console.WriteLine("Current Account Balance is {0} Taka", this.balance);
            }
            else
            {
                Console.WriteLine("Must Deposite 500 taka or more!!");
            }
        }
        internal virtual void ShowInfo()
        {
            Console.WriteLine("General Information of Account:");
            Console.WriteLine("Account Holder's Name: {0}",this.name);
            Console.WriteLine("Account ID Number    : {0}",this.id);
            Console.WriteLine("Account Balance      : {0} Taka",this.balance);
            this.openingDate.PrintDate();
        }

    }
}
