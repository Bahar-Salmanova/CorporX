using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.Models
{
    public class Promo
    {
        public int Id { get; set; }

       [MaxLength(100)]
        public string Icon { get; set; }
        [Required,MaxLength(200)]
        public string Title { get; set; }

        [Required, MaxLength(300)]
        public string Desc { get; set; }
    }
}
