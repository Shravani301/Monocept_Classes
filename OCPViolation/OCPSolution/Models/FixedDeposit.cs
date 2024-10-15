using OCPSolution.Festivals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPSolution.Models
{
    internal class FixedDeposit
    {
        private int _accountNumber;
        private string _accountHolderName;
        private double _principal;
        private int _duration;
        private IFestival _festival;
        public const int DIVISOR = 100;

        public FixedDeposit(int accountNumber, string accountHolderName, double principal,
            int duration, IFestival festival)
        {
            _accountNumber = accountNumber;
            _accountHolderName = accountHolderName;
            _principal = principal;
            _duration = duration;
            _festival = festival;
        }
        
        public double CalculateSimpleInterest()
        {
            return (_principal * _duration * _festival.GetInterestRate()) / DIVISOR;
        }
    }
}
