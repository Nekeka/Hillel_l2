using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Money
    {

        public int Dollars
        {
            get;
            private set;
        }

        public int Cents
        {
            get;
            private set;
        }

        public void PrintMoney()
        {
            Console.WriteLine($"Dollars: {Dollars}\nCents: {Cents}");
        }

        public void SetMoney(int dollars, int cents)
        {
            if (dollars >= 0)
                Dollars = dollars;
            else
                throw new Exception("dollars must be >=0");
               
            if (cents>=0 && cents<=99)
                Cents = cents;
            else
                throw new Exception("cents must be >=0 and <100");
        }
       public Money()
        {
            Dollars = 0;
            Cents = 0;
        }
        public Money(int money)
        {
            Dollars = money;
            Cents = 0;
        }
        public Money(int dollars, int cents)
        {
            Dollars = dollars;
            Cents = cents;
        }

    }
}
