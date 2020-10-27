using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.Models
{
    public class Services
    {
        public int Id { get; set; }

        [Required,MaxLength(200)]
        public string Name { get; set; }

        [Required,MaxLength(100)]        
        public string Icon { get; set; }

        [Required,MaxLength(300)]
        [Column(TypeName="ntext")]
        public string Text { get; set; }
    }
}
