using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DiamondApi.Models
{
    public class Retailer
    {
        [ForeignKey("Diamond")]
        public int RetailerId { get; set; }

        [StringLength(maximumLength: 250, MinimumLength = 3)]
        public string RetailerName { get; set; }

        public virtual Diamond Diamond { get; set; }
    }
}
