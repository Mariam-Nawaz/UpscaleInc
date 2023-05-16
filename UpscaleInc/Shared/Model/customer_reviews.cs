using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upscaleInc.Shared
{
    public class customer_reviews
    {
        [Key]
        public string email { get; set; }
        public string Name { get; set; }
        public string comment { get; set; }
        public string Phn { get; set; }
    }
}
