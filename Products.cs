using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LiveCode4
{
    class Product
    {
        [Column("ProductId")]
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public String ProductName { get; set; }
        public int CategoryId { get; set; }
        public String QuantityUnit { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
