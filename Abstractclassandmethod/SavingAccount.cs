using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractclassandmethod
{
    internal  class SavingAccount:BankAccount
    {
        
        public double InterestAmount { get; set; }

        public override void Transfer(string to, string form, double amount)
        {
           //throw new NotImplementedException();
        }

        public override string Withdraw(double amount) {
            if (Balance >= amount)
            {
                return base.Withdraw(amount);

            }
            return "Insificent Ballence";

        }
       

    }

}
