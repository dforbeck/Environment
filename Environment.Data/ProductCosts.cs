using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Environment.Data
{
    class Costs
    {
        [Key]
        public int CostItemID { get; set; }
        public int ProductsID { get; set; }

        public double CostWithTRACI { get; set; }
        public double CostsWOTRACI { get; set; }

        public virtual Products Products { get; set; }
    }

}

