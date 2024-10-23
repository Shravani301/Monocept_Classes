using DIPSolution.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolution.Models
{
    internal class TaxCalculator
    {
        ILogger logger;
        public TaxCalculator(ILogger logger)
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
                logger.Log(ex.Message);
            }
            catch (Exception ex)
            {
                logger.Log(ex.Message);
            }
            return tax;
        }
    }
}
