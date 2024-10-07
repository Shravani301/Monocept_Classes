using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticInstanceDemo.Models
{
    internal class Account
    {
        public int AccountId { get; set; }
        public string AccountHolderName { get; set; }
        public string BankName { get; set; }
        public double Balance { get; set; }

        public static int MINIMUM_BALANCE = 500;

    }
}


