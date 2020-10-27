using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Models
{
    public class News
      
    {  public int Id { get; set; }

        [Required,MaxLength(200)]
        public string Title { get; set; }

        [MaxLength(200)]
        public string Photo { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }

        public DateTime Date { get; set; }

        [Required,MaxLength(50)]
        public string Position { get; set; }

        [MaxLength(500),Required]
        [Column(TypeName="ntext")]
        public string Text { get; set; }

    }
}
