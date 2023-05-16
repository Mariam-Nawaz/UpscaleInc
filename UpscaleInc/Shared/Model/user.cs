using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upscaleInc.Shared
{
    public class user
    {
        [Key]
        public string email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Phn { get; set; }
    }
}
