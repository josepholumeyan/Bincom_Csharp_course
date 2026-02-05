namespace BincomProject.Services
{
    public static class TaxCalculatorService
    {
        public static decimal CalculateTax(decimal income)
        {
            double pensionRate = 0.08;
            double CRA_RATE = 0.20;

            double CRA = ((double)income * CRA_RATE) + 200000;
            double pension = (double)income * pensionRate;

            double taxableIncome = (double)income - CRA - pension;

            if (taxableIncome <= 0)
            {
                return 0;
            }
            else if (taxableIncome <= 30000)
            {
                return (decimal)(taxableIncome * 0.07);
            }
            else if (taxableIncome <= 60000)
            {
                return (decimal)(2100 + (taxableIncome - 30000) * 0.11);
            }
            else if (taxableIncome <= 110000)
            {
                return (decimal)(5400 + (taxableIncome - 60000) * 0.15);
            }
            else if (taxableIncome <= 200000)
            {
                return (decimal)(12900 + (taxableIncome - 110000) * 0.19);
            }
            else if (taxableIncome <= 300000)
            {
                return (decimal)(30000 + (taxableIncome - 200000) * 0.21);
            }
            else if (taxableIncome <= 400000)
            {
                return (decimal)(51000 + (taxableIncome - 300000) * 0.24);
            }
            else if (taxableIncome <= 500000)
            {
                return (decimal)(75000 + (taxableIncome - 400000) * 0.27);
            }
            else if (taxableIncome <= 600000)
            {
                return (decimal)(102000 + (taxableIncome - 500000) * 0.30);
            }
            else
            {
                return (decimal)(132000 + (taxableIncome - 600000) * 0.32);
            }
        }
    }
}
