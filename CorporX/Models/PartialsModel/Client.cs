using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Column(TypeName ="ntext")]
        [MaxLength(300)]
        public string Text { get; set; }

        [Required,MaxLength(50)]
        public string FullName { get; set; }

        [Required,MaxLength(50)]
        public string Company { get; set; }

        [MaxLength(100)]
        public string Photo { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }
    }
}
