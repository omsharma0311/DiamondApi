using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiamondApi.Models
{
    public class DiamondImage
    {
        public int DiamondImageId { get; set; }

        [StringLength(maximumLength: 250, MinimumLength = 3)]
        public string DiamondTopImage { get; set; }
        public Diamond Diamond { get; set; }

    }
}
