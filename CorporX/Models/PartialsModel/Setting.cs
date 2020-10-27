using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Models
{
    public class Setting
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Logo { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(100)]
        public string HeadAdress { get; set; }

        [MaxLength(50)]
        public string Phone { get; set; }

       [MaxLength(150)]
        public string HeadquartersAdress { get; set; }
        
        [MaxLength(100)]
        public string HeadquartersPhone { get; set; }
        [MaxLength(100)]
        public string HeadquartersEmail { get; set; }
    }
}
