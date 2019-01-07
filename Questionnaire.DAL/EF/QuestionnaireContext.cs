using Questionnaire.DAL.Entities;
using System.Data.Entity;

namespace Questionnaire.Models
{
    public class QuestionnaireContext : DbContext
    {
        static QuestionnaireContext()
        {
            Database.SetInitializer(new QuestionnaireContextInitializer());
        }

        public QuestionnaireContext(string connectionString) : base (connectionString)
        {

        }

        public DbSet<BusinessArea> BusinessAreas { get; set; }
        public DbSet<BusinessAreaCompany> BusinessAreaCompanies { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Region> Regions { get; set; }
    }
}