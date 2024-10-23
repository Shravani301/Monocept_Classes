using DIPViolationApp.LLM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp.HLM
{
    internal class TaxCalculator
    {
        DbLogger logger;
        public TaxCalculator()
        { 
            logger = new DbLogger();
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
