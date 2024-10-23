using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApp
{
    internal class DataService
    {
        private static DataService _instance;
        public static DataService GetInstance()
        {
            if(_instance == null)
                _instance = new DataService();
            return _instance;
        }
    }
}
