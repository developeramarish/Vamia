﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vamia.Models
{
    public class ItemModel
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public ProductModel Product { get; set; }
    }
}
