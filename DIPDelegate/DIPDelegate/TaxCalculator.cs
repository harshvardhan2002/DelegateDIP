using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPDelegate
{
    internal class TaxCalculator
    {
        private Action _logger;//for returning message if any error
        private Func<int, int, int> _calculateTaxFunc;//for tax calculation
        public TaxCalculator(Action logger, Func<int, int, int> calculateTaxFunc)
        {
            _logger = logger;
            _calculateTaxFunc = calculateTaxFunc;
        }

        public int CalculateTax(int amount, int rate)
        {
            try
            {
                return _calculateTaxFunc(amount, rate);
            }
            catch (Exception)
            {
                _logger();
                return 0;
            }
            
        }
    }
}
