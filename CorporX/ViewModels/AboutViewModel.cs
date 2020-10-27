using CorporX.Models;
using CorporX.Models.Partials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.ViewModels
{
    public class AboutViewModel
    {
        public Breadcrumb Breadcrumb { get; set; }
        public List<Promo> Promos { get; set; }
        public Mission Mission { get; set; }
        public List<DeliverService> DeliverService { get; set; }
        public List<Member> Members { get; set; }
        public List<MemberLink> MemberLinks { get; set; }
        public List<Client> Clients { get; set; }
        public List<Partners> Partners { get; set; }

    }
}
