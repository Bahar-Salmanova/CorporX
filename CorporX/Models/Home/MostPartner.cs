using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Models
{
    public class MostPartner
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string About { get; set; }

        [Required, MaxLength(100)]
        public string Title { get; set; }

        [Column(TypeName ="ntext")]
        public string Desc { get; set; }

        [MaxLength(50)]
        public string Button { get; set; }
        [MaxLength(100)]
        public string Photo { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }
    }
}
