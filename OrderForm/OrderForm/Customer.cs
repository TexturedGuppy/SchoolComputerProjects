using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderForm
{
    class Customer
    {
        private static int nextID = 1;
        private string name;
        private int id;

        public List<Order> orders;

        //address
        //billing address (if different)
        //phone number
        //zip code
        //state, city
        public Customer(string name = "Customer") //Default parameter or pass in own name
        {
            this.name = name;
            id = nextID++;
            orders = new List<Order>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return name + " " + id; 
        }


    }
}
