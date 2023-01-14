using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractclassandmethod
{
    internal abstract class BankAccount
    {
        public string AccountNo { get; set; }
        public  string CustomarName { get; set; }
        public double Balance { get; set; }



        public virtual string  Withdraw(double amount)
        {

            Balance -= amount;
            return "withraw";

            //if(Balance >=amount)
            //{

            //    Balance -= amount;
            //    return "withraw";
            //}

            //return "Insaficent Balance";
        }

        public  string  Deposit(double amount)
        {

            Balance += amount;
            return "depsit succesfull";
        }


        public abstract void Transfer(string to, string form, double amount);





    }
}
