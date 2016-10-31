using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderForm
{
    class Order
    {
        List<string> items;
        int customerID;
        double total;
        int quantity;
        public DateTime date;

        public override string ToString()
        {
            return date.ToString();
        }
    }
}
