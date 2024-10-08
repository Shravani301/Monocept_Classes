using AccountLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLibrary.Models
{
    public class Transaction
    {
        public string Id { get; set; }
        public TransactionType Type { get; set; }
        public double Amount { get; set; }
        public DateTime DateTime { get; set; }
        public int AccountId { get; set; }


        public static string GenerateTransactionId(int accId)
        {
            return "TXID" + accId + DateTime.Now.Ticks;

        }

    }
}

