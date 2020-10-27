using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.Models.Partials
{
    public class Breadcrumb
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
       
    }
}
