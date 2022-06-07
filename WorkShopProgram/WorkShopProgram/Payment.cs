using System;
using System.Collections.Generic;
using System.Text;

namespace WorkShopProgram
{
    class Payment
    {
        public double principle;
        public double year;
        public double rate;
        public Payment(double principle, double year, double rate)
        {
            this.principle = principle;
            this.year = year;
            this.rate = rate;
        }

        public void Calculate()
        {
            double n = this.year * 12;
            double r = this.rate / (12 * 100);
            double data = this.principle * r;
            double Power = Math.Pow(1 + r, -n);
            double value = (1 - Power);
            double calculation = data / value;
            Console.WriteLine(calculation);


        }
    }
}
