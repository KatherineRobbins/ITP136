using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw14
{
    class Orders
    {
        public Orders(string n, string f, string t)
        {
            OrderName = n;
            OrderFlavor = f;
            OrderTopping = t;
        }

        public string OrderName { get; set; }
        public string OrderFlavor { get; set; }
        public string OrderTopping { get; set; }
    }
}
