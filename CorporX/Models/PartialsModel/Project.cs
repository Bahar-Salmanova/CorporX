using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        public string Category { get; set; }

        [Required,MaxLength(50)]
        public string Position { get; set; }

        [Required,MaxLength(50)]
        public string Specialty { get; set; }
        [MaxLength(100)]
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }


    }
}
