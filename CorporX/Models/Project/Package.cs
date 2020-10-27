using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Models
{
    public class Package
    {
        public int Id { get; set; }

        [Required]
        public int OrderBy { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Photo { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        [Required,MaxLength(1000)]
        public string Options { get; set; }

    }
}
