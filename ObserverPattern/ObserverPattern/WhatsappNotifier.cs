using ObserverAccountLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class WhatsappNotifier:INotifier
    {
        public string Notify(Account account)
        {
            return $"whatsapp message sent to {account.AccountHolderName}\n" +
                $"Account id:{account.AccountNo}\n" +
                $"Your Updated Balance is:{account.Balance}\n";
        }
    }
}
