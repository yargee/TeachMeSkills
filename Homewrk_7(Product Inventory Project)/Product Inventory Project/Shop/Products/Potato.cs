using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryProject.Shop.Products
{
    internal class Potato : Product
    {
        public Potato(int id, int price, int quantity, string description) : base(id, price, quantity, description)
        {
        }
    }
}
