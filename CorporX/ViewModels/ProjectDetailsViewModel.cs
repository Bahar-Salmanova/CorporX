using CorporX.Models;
using CorporX.Models.Partials;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.ViewModels
{
    public class ProjectDetailsViewModel
    {
        public Breadcrumb Breadcrumb { get; set; }
       
        public ProjectDescription ProjectDescription { get; set; }
        public List< ProjectDescriptionItem>ProjectDescriptionItem { get; set; }
        




    }
}
