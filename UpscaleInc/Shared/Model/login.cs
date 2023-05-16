using System.ComponentModel.DataAnnotations;

namespace UpscaleInc.Shared
{
    public class login
    {
        [Key]
        public string email { get; set; }
        public string password { get; set; }
    }
}
