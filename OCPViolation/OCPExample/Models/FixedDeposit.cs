using OCPExample.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPExample.Models
{
    internal class FixedDeposit
    {
        private int _accountNumber;
        private string _accountHolderName;
        private double _principal;
        private int _duration;
        private FestivalType _festival;
        public const int DIVISOR = 100;

        public FixedDeposit(int accountNumber, string accountHolderName, double principal,
            int duration, FestivalType festival)
        { 
            _accountNumber = accountNumber;
            _accountHolderName = accountHolderName;
            _principal = principal;
            _duration = duration;
            _festival = festival;
        }
        private static double GetInterestRate(FestivalType festival)
        {
            if (festival == FestivalType.NEWYEAR)
                return 8.0;
            else if (festival == FestivalType.DIWALI)
                return 8.5;
            else if (festival == FestivalType.HOLI)
                return 7.5;
            else if (festival == FestivalType.OTHERS)
                return 6.5;            
            return 0;
        }
        public static double CalculateSimpleInterest(FixedDeposit fixedDeposit)
        { 
            return (fixedDeposit._principal*fixedDeposit._duration*GetInterestRate(fixedDeposit._festival))/DIVISOR;
        }
    }
}
