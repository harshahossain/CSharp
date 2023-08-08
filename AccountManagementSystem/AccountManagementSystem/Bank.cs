using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    internal class Bank
    {
        AccountGeneral[] bankAccount=new AccountGeneral[200];
        private int index = 0;
        internal void AddAccount(AccountGeneral a) 
        {
            bankAccount[index] = a;
            index++;
        }
        internal void ShowAllAccount()
        {
            int count = 0;
            while(count<index)
            {
                bankAccount[count].ShowInfo();
                count++;
            }
        }
    }
}
