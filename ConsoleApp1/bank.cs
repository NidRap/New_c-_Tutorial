using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp1
{

    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get;

        }


        private static int accountNumberSeed = 1234567890;
        private List<Transaction> allTransactions = new List<Transaction>();
        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            //fgujfutygyh
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
       
        }


}
    }
class Worker
{
    internal object CollectData(int v)
    {
        throw new NotImplementedException();
    }

    internal object CollectDataAsync(int v)
    {
        throw new NotImplementedException();
    }
}


