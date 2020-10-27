using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.Models
{
    public class BusinesSolutionItem
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }


       [Column(TypeName ="ntext")]
       [MaxLength(100)]
        public string Desc { get; set; }
    }
}
