using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Models
{
    public class ProjectDescription
    {
        public int Id { get; set; }
        [Required,MaxLength(150)]
        public string Title { get; set; }

        [Required, MaxLength(1000)]
        public string Desc { get; set; }

        [ MaxLength(100)]
        public string Photo { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }
    }
}
