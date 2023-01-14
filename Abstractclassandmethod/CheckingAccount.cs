using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractclassandmethod
{
    internal class CheckingAccount:BankAccount
    {
        //public CheckingAccount(string amount,double servicecharge)
        //{
        //    servicecharge = Servicecharge;
        //}
        public double Servicecharge { get; set; }

        public override void Transfer(string to, string form, double amount)
        {
           // todo;
        }
    }
}
