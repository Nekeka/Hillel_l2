using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Product : Money
    {
        public string ProductName { get; private set; }

        public Product(string name): base()
        {
            ProductName = name;
        }

        public Product(string name, int dollars) : base(dollars)
        {
            ProductName = name;
        }
        public Product(string name, int dollars, int cents) : base(dollars, cents)
        {
            ProductName = name;
        }

        public void ReducePrice()
        {

        }

    }
}
