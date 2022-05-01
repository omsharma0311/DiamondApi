using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiamondApi.Models
{
    public class Diamond
    {
        [Required(ErrorMessage = "Diamond is not valid.")]
        public int DiamondId { get; set; }

        public string DiamondType { get; set; }


        [StringLength(maximumLength: 250, MinimumLength = 3)]
        public string DiamindShape { get; set; }

        public int DiamondPrice { get; set; }


        [StringLength(maximumLength: 250, MinimumLength = 3)]
        public string DiamondColor { get; set; }


        [StringLength(maximumLength: 250, MinimumLength = 3)]
        public string  DiamondCarat { get; set; }

        public virtual  Retailer RetailerDetails { get; set; }

        public DiamondImage diamondImage { get; set; }

    }
}
