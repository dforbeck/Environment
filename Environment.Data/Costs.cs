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
        public int CostItem { get; set; }
        public double CostWithTRACI { get; set; }
        public double CostsWOTRACI { get; set; }

        public virtual Products ProductID { get; set; }
    }

}
}
