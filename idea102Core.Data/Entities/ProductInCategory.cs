using System;
using System.Collections.Generic;
using System.Text;

namespace idea102Core.Data.Entities
{
    public class ProductInCategory
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int CategoryId { get; set; }

        public ProductCategory Category { get; set; }
    }
}
