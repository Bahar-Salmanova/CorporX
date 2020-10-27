using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Models
{
    public class Member
    {
        public int Id { get; set; }


        [Required,MaxLength(100)]
        public string FullName { get; set; }

        [Required,MaxLength(100)]
        public string Position { get; set; }

        [MaxLength(200)]
        public string About { get; set; }

        [MaxLength(100)]
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }
        public ICollection<MemberLink> MemberLinks { get; set; }
    }
}
