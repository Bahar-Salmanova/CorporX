using CorporX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.ViewModels
{
    public class HomeViewModel
    {
        public MostPartner Mpartner { get; set; }
        public List<Promo> Promos { get; set; }
        public BusinesSolution BusinesSolution { get; set; }
        public List< BusinesSolutionItem >BusinesSolutionItem { get; set; }
        public List<Services> Services { get; set; }
        public Download Download { get; set; }
        public List<ButtonDownload> ButtonDownloads { get; set; }
       
        public List<Project> Projects { get; set; }
        public List<News> News { get; set; }
        public List<Client> Clients { get; set; }
        public List<Member> Members { get; set; }
        public List<MemberLink> MemberLinks { get; set; }
    }
}
