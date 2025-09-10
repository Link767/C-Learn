using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    class CableProduct : Product
    {
        public double Length { get; set;}
        public CableProduct(string name, decimal price, int quantity, double length) : base(name, price, quantity)
        {
            Length = length;
        }
    }
}
