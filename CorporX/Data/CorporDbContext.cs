


using CorporX.Models;
using CorporX.Models.Partials;
using Microsoft.EntityFrameworkCore;

namespace CorporX.Data
{
    public class CorporDbContext:DbContext
    {
        public CorporDbContext(DbContextOptions<CorporDbContext> options) : base(options)
        {

        }
        public DbSet<BusinesSolution> BusinesSolutions { get; set; }
        public DbSet<BusinesSolutionItem> BusinesSolutionItems { get; set; }
        public DbSet<Download> Downloads { get; set; }
        public DbSet<ButtonDownload>ButtonDownloads { get; set; }
        public DbSet<MostPartner> MostPartners { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<DeliverService> DeliverServices { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<AnswerQuestions> AnswerQuestions { get; set; }
        public DbSet<AskedQuestions> AskedQuestions { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<ProjectDescription> ProjectDescriptions { get; set; }
        public DbSet<ProjectDescriptionItem> ProjectDescriptionItems { get; set; }
       
        
        public DbSet<Client> Clients { get; set; }
        public DbSet<LastHead> LastHeads { get; set; }
        public DbSet<Breadcrumb> Breadcrumbs { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberLink> MemberLinks { get; set; }

        public DbSet<Partners> Partners { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Promo> Promos { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SosialLink> SosialLinks { get; set; }
    }
}
