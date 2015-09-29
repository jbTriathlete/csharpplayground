using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpplayground
{
    interface ITransaction
    {
       string showTransaction();
       double getAmount();
    }

    public class Transaction:ITransaction
    {
        private string tCode;
        private string date;
        private double amount;

        public Transaction()
        {
            tCode = "";
            date = "";
            amount = 0.0;
        }

        public Transaction(string inCode, string inDt, double inAmt)
        {
            tCode = inCode;
            date = inDt;
            amount = inAmt;
        }

        public double getAmount()
        {
            return amount;
        }

        public string showTransaction()
        {
            string str;
            str = "Transaction:" + tCode + System.Environment.NewLine;
            str = str + "Date:" + date + System.Environment.NewLine;
            str = str + "Amount:" + amount + System.Environment.NewLine;
            return str;
        }
    }
}
