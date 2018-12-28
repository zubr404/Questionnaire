using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Questionnaire.DAL.Entities
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string WebsiteAddress { get; set; }
        public string AddressOnlineStore { get; set; }
        public int RegionId { get; set; }
        public int CityId { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        public ICollection<BusinessAreaCompany> BusinessAreaCompanies { get; set; }
        public Company()
        {
            BusinessAreaCompanies = new List<BusinessAreaCompany>();
        }
    }
}
