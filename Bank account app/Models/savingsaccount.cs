using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_account_app.Models
{
    public class savingsaccount: BankAccount  // savingsaccount is a child class of bankaccount parent class...so no need to define properties of parentclass(inheritance)
    {
        public decimal interestrate {  get; set; }

        public savingsaccount(string owner,decimal IR) : base(owner+$"({IR}%)") //constructor for savingaccount as base is bankaccount so its possible to pass and add with the rest of the properties
        {
            interestrate=IR;
        }
        public savingsaccount(string owner, decimal IR, decimal initialBalance = 0) : base(owner+$"({IR}%)",initialBalance)
        {
            interestrate=IR;
        }

        public override string deposit(decimal amount)
        {
            if (amount<=0)
            {
                return $"You cannot deposit ${amount}";
            }
            if (amount>20000)
            {
                return $"Maximum Deposit limit reached.";
            }
            decimal interestamount = amount*(interestrate/100);
            Balance+=amount+interestamount;
            return "Money deposited successfully";
        }

    }
}
