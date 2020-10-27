using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.Models
{
    public class Partners
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }

        [MaxLength(100)]
        public string Url { get; set; }
    }
}
