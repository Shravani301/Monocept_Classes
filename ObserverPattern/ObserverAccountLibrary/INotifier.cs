using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverAccountLibrary
{
    public interface INotifier
    {
        string Notify(Account account);
    }
}
