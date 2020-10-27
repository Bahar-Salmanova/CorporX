using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Models
{
    public class Mission
    {
        public int Id { get; set; }

        [Required,MaxLength(100)]

        public string Title { get; set; }

        [Required,MaxLength(200)]
        public string Desc { get; set; }

        [MaxLength(50)]
        public int TotalProjectPrice { get; set; }

        [MaxLength(50)]
        public int TotalCustomerPrice { get; set; }

        [MaxLength(50)]
        public int TotalProject { get; set; }

        [MaxLength(50)]
        public string Photo { get; set; }


        [NotMapped]
        public IFormFile Upload { get; set; }
    }
}
