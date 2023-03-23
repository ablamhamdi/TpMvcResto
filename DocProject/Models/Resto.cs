using Microsoft.Build.Framework;

namespace DocProject.Models
{
    public class Resto
    {
        public int uuid { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        
        public byte rating { get; set; }


    }
}
