using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.Models
{
    public class MemberLink
    {
        public int Id { get; set; }
        [Required]
        public int MemberId { get; set; }

        [Required,MaxLength(50)]
       
        public string Url { get; set; }

        [MaxLength(100)]
        public string Icon { get; set; }
        public Member Members { get; set; }
    }
}
