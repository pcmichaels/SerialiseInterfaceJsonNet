﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialiseInterfaceJsonNet
{
    public interface IProduct
    {
        int Id { get; set; }
        decimal UnitPrice { get; set; }

    }
}
