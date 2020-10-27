using System.ComponentModel.DataAnnotations;

namespace CorporX.Models
{
    public class SosialLink
    {
        public int Id { get; set; } 

        [Required]
        public int OrderBy { get; set; }

        [Required,MaxLength(50)]
        public string Icon { get; set; }

        [Required,MaxLength(100)]
        public string Url { get; set; }
       
    }
}
