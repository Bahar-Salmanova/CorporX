using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Models
{
    public class BusinesSolution
    {
        public int Id { get; set; }

        [Required,MaxLength(200)]
        public string Title { get; set; }

        [MaxLength(200)]
        public string Text { get; set; }
        [MaxLength(100)]

        public string Photo { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }


    }
}
