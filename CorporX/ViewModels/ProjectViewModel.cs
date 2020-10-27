using CorporX.Models;
using CorporX.Models.Partials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.ViewModels
{
    public class ProjectViewModel
    {
        public Breadcrumb Breadcrumb { get; set; }
        public List< Project> Projects { get; set; }
        public List<Package> Packages { get; set; }
        public List<Client> Clients { get; set; }
        public List<Partners> Partners { get; set; }

    }
}
