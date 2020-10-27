using CorporX.Models;
using CorporX.Models.Partials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.ViewModels
{
    public class ServicesViewModel
    {
        public Breadcrumb Breadcrumb { get; set; }
        public List<Promo> Promos { get; set; }
        public List<Services> Services { get; set; }
        public List<Partners> Partners { get; set; }

    }
}
