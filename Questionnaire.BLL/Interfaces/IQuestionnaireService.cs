using Questionnaire.BLL.DTO;
using System.Collections.Generic;

namespace Questionnaire.BLL.Interfaces
{
    public interface IQuestionnaireService
    {
        void MakeQuestionnaire(CompanyDTO companyDTO);
        IEnumerable<BusinessAreaDTO> GetBusinessAreaDTO();
        IEnumerable<RegionDTO> GetRegionDTO();
        IEnumerable<CityDTO> GetCityDTO();
        IEnumerable<CityDTO> GetCityDTO(int regionId);
        void Dispose();
    }
}
