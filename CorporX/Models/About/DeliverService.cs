using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Models
{
    public class DeliverService
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Photo { get; set; }

        [Required,MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(200)]
        public string Text { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }
    }
}
