using System.Collections.Generic;

namespace Questionnaire.Web.Models
{
    public class CompanyViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string WebsiteAddress { get; set; }
        public string AddressOnlineStore { get; set; }
        public int RegionId { get; set; }
        public int CityId { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public ICollection<BusinessAreaCompanyViewModel> BusinessAreaCompanies { get; set; }
        public CompanyViewModel()
        {
            BusinessAreaCompanies = new List<BusinessAreaCompanyViewModel>();
        }
    }
}