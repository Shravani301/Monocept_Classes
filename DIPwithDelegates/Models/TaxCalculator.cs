using DIPwithDelegates.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPwithDelegates.Models
{
    internal class TaxCalculator
    {
        DLogDelegate logger;
        public TaxCalculator(DLogDelegate logger)
        {
            this.logger = logger;
        }

        public int CalculateTax(int amount, int rate)
        {
            int tax = 0;
            try
            {
                tax = amount / rate;
            }
            catch (DivideByZeroException ex)
            {
                logger.Invoke(ex.Message);
            }
            catch (Exception ex)
            {
                logger.Invoke(ex.Message);
            }
            return tax;



        }
    }
}