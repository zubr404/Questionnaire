using Questionnaire.BLL.DTO;
using Questionnaire.BLL.Interfaces;
using Questionnaire.DAL.Entities;
using Questionnaire.DAL.Interfaces;
using System.Collections.Generic;

namespace Questionnaire.BLL.Services
{
    public class QuestionnaireService : IQuestionnaireService
    {
        IUnitOfWork Database { get; set; }

        public QuestionnaireService(IUnitOfWork unitOfWork)
        {
            Database = unitOfWork;
        }

        public IEnumerable<BusinessAreaDTO> GetBusinessAreaDTO()
        {
            MapService map = new MapService();
            return map.Mapping<BusinessArea, BusinessAreaDTO>(Database.BusinessArea.GetAll());
        }

        public IEnumerable<CityDTO> GetCityDTO()
        {
            MapService map = new MapService();
            return map.Mapping<City, CityDTO>(Database.City.GetAll());
        }

        public IEnumerable<CityDTO> GetCityDTO(int regionId)
        {
            MapService map = new MapService();
            return map.Mapping<City, CityDTO>(Database.City.GetPart(regionId));
        }

        public IEnumerable<RegionDTO> GetRegionDTO()
        {
            MapService map = new MapService();
            return map.Mapping<Region, RegionDTO>(Database.Region.GetAll());
        }

        public void MakeQuestionnaire(CompanyDTO companyDTO)
        {
            Company company = new Company
            {
                Name = companyDTO.Name,
                WebsiteAddress = companyDTO.WebsiteAddress,
                AddressOnlineStore = companyDTO.AddressOnlineStore,
                RegionId = companyDTO.RegionId,
                CityId = companyDTO.CityId,
                BusinessAreaCompanies = new MapService().Mapping<BusinessAreaCompanyDTO, BusinessAreaCompany>(companyDTO.BusinessAreaCompanies)
            };

            Database.Company.Create(company);
            Database.Save();
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
