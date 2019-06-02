using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Environment.Data
{
    class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public string SubBrand { get; set; }
        public string ProductName { get; set; }
    }
}
