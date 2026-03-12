using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_account_app.Models
{
    public class BankAccount
    {
        public string owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; protected set; }

        //creating a constructor...Constructor is a part to construct the objects...instead of hardcoding we will use constructor to logically build the project
        public BankAccount(string Owner)
        {
            owner=Owner;
            AccountNumber = Guid.NewGuid();
            Balance=0;
        }
        public BankAccount(string Owner,decimal initialBalance = 0)
        {
            owner = Owner;
            AccountNumber = Guid.NewGuid();
            Balance = initialBalance;
        }

        //encapsulation
        public virtual string deposit(decimal amount)
        {
            if (amount<=0)
            {
                return $"You cannot deposit ${amount}";
            }
            if (amount>20000)
            {
                return $"Maximum Deposit limit reached.";
            }

            Balance+=amount;
            return "Money deposited successfully";
        }

        public string withdraw(decimal amount)
        {
            if (amount<=0)
            {
                return $"You cannot withdraw ${amount}";
            }
            if (amount>Balance)
            {
                return $"You donnot have enough money.";
            }

            Balance-=amount;
            return "Money deposited successfully";
        }
    }
}
