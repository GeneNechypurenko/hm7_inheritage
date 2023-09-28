using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace hm7_inheritage
{
    internal class Product
    {
        public Money Price { get; set; }
        public override string ToString() => $"Product price is {Price.Currency}.{Price.Cents}";
        public void DecreacePrice(int changeCurrency, int changeCents)
        {
            Price.Currency -= changeCurrency;
            Price.Cents -= changeCents;
        }
        public void IncreacePrice(int changeCurrency, int changeCents)
        {
            Price.Currency += changeCurrency;
            Price.Cents += changeCents;
        }
    }
}
