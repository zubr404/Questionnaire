using System.Collections.Generic;

namespace Questionnaire.BLL.DTO
{
    public class CompanyDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string WebsiteAddress { get; set; }
        public string AddressOnlineStore { get; set; }
        public int RegionId { get; set; }
        public int CityId { get; set; }

        public int UserId { get; set; }
        public UserDTO User { get; set; }

        public ICollection<BusinessAreaCompanyDTO> BusinessAreaCompanies { get; set; }
        public CompanyDTO()
        {
            BusinessAreaCompanies = new List<BusinessAreaCompanyDTO>();
        }
    }
}
