using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialiseInterfaceJsonNet
{
    class Product : IProduct
    {
        public int Id { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
