using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Abstractclassandmethod;
using Microsoft.Win32.SafeHandles;

namespace Abstractclassandmethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingAccount saving = new SavingAccount();
            saving.InterestAmount = 399;
            saving.AccountNo = "sav-101";
            saving.CustomarName = "Ismail";

            BankAccount b2 = saving;
            b2.Transfer("","",44);


            BankAccount bank = new CheckingAccount();
            

            CheckingAccount checking = new CheckingAccount();
            BankAccount b3 = checking;
            b3.Transfer("Dhaka","Dhamondi",444);

            checking.Servicecharge= 440;
            checking.AccountNo = "cha-102";
            checking.CustomarName = "Thasin";
          //  checking.Transfer("", "", 440);

            Console.ReadKey();

        }
    }
}
