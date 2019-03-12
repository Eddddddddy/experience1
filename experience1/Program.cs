using System;

namespace experience1
{
    class CommissionEmployee
    {
        private int number;
        private String name;
        private double salesValue, percentageValue;

        public CommissionEmployee(int number,String name,double salesValue,double percentageValue)
        {
            this.name = name;
            this.number = number;
            this.salesValue = salesValue;
            this.percentageValue = percentageValue;
        }

        String getName()
        {
            return name;
        }

        int getNumber()
        {
            return number;
        }

        double getSalesValue()
        {
            return salesValue;
        }

        double getPercentageValue()
        {
            return percentageValue;
        }

        void setName(String name)
        {
            this.name = name;
        }

        void setNumber(int number)
        {
            this.number = number;
        }

        void setSalesValue(double salesValue)
        {
            this.salesValue = salesValue;
        }

        void setPercentageValue(double percentageValue)
        {
            this.percentageValue = percentageValue;
        }

        double salary()
        {
            
        }
    }
    
    
    
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}