using AutoMapper;
using Questionnaire.BLL.DTO;
using Questionnaire.BLL.Interfaces;
using Questionnaire.DAL.Entities;
using Questionnaire.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace Questionnaire.BLL.Services
{
    class QuestionnaireService : IQuestionnaireService
    {
        IUnitOfWork Database { get; set; }

        public QuestionnaireService(IUnitOfWork unitOfWork)
        {
            Database = unitOfWork;
        }

        public IEnumerable<BusinessAreaDTO> GetBusinessAreaDTO()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<BusinessArea, BusinessAreaDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<BusinessArea>, List<BusinessAreaDTO>>(Database.BusinessArea.GetAll());
        }

        public IEnumerable<CityDTO> GetCityDTO(int regionId)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<City, CityDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<City>, List<CityDTO>>(Database.City.Get(regionId));
        }

        public IEnumerable<RegionDTO> GetRegionDTO()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Region, RegionDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Region>, List<RegionDTO>>(Database.Region.GetAll());
        }

        public void MakeQuestionnaire(BusinessAreaCompanyDTO businessAreaCompanyDTO, BusinessAreaDTO businessAreaDTO, CityDTO cityDTO, CompanyDTO companyDTO, RegionDTO regionDTO, UserDTO userDTO)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Database.Dispose();
        }

    }
}
