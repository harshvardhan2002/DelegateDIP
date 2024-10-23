namespace DIPDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbLogger = new DBLogger();
            Action actionDbPtr = dbLogger.Log;

            var fileLogger=new FileLogger();
            Action actionFilePtr=fileLogger.Log;

            Func<int, int, int> taxCalcDekegate = CalculateTaxMethod;
            var taxCalculatorDb = new TaxCalculator(actionDbPtr, taxCalcDekegate);
            Console.WriteLine(taxCalculatorDb.CalculateTax(100,0));
        }
        public static int CalculateTaxMethod(int amount, int rate)//this method method will be called as function pointer (when defined func)
        {
            return amount / rate;
        }
    }
}
