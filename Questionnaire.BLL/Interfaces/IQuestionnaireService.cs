using Questionnaire.BLL.DTO;
using System.Collections.Generic;

namespace Questionnaire.BLL.Interfaces
{
    public interface IQuestionnaireService
    {
        void MakeQuestionnaire(BusinessAreaCompanyDTO businessAreaCompanyDTO,
            BusinessAreaDTO businessAreaDTO,
            CityDTO cityDTO,
            CompanyDTO companyDTO,
            RegionDTO regionDTO,
            UserDTO userDTO);
        IEnumerable<BusinessAreaDTO> GetBusinessAreaDTO();
        IEnumerable<RegionDTO> GetRegionDTO();
        IEnumerable<CityDTO> GetCityDTO(int regionId);
        void Dispose();
    }
}
