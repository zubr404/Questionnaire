using Questionnaire.BLL.DTO;
using Questionnaire.BLL.Interfaces;
using Questionnaire.BLL.Services;
using Questionnaire.Web.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Questionnaire.Web.Controllers
{
    public class HomeController : Controller
    {
        IQuestionnaireService questionnaireService;
        public HomeController(IQuestionnaireService service)
        {
            questionnaireService = service;
        }

        public ActionResult Index()
        {
            MapService map = new MapService();

            IEnumerable<RegionDTO> regionDTOs = questionnaireService.GetRegionDTO();
            ViewBag.Regions = new SelectList(map.Mapping<RegionDTO, RegionViewModel>(regionDTOs), "Id", "Name");

            IEnumerable<CityDTO> cityDTOs = questionnaireService.GetCityDTO();
            ViewBag.Cities = new SelectList(map.Mapping<CityDTO, CityViewModel>(cityDTOs), "Id", "Name");

            IEnumerable<BusinessAreaDTO> businessAreaDTOs = questionnaireService.GetBusinessAreaDTO();
            ViewBag.BusinessAreas = new MultiSelectList(map.Mapping<BusinessAreaDTO, BusinessAreaViewModel>(businessAreaDTOs), "Id", "Name");
             
            return View();
        }

        public ActionResult GetCities(int id)
        {
            MapService map = new MapService();

            IEnumerable<CityDTO> cityDTOs = questionnaireService.GetCityDTO(id);
            return PartialView(map.Mapping<CityDTO, CityViewModel>(cityDTOs));
        }

        [HttpPost]
        public string MakeCompany(CompanyViewModel company)
        {
            var companyDTO = new CompanyDTO
            {
                Id = company.Id,
                Name = company.Name,
                WebsiteAddress = company.WebsiteAddress,
                AddressOnlineStore = company.AddressOnlineStore,
                RegionId = company.RegionId,
                CityId = company.CityId,
                Email = company.Email,
                Login = company.Login,
                Password = company.Password,
                BusinessAreaCompanies = new MapService().Mapping<BusinessAreaCompanyViewModel, BusinessAreaCompanyDTO>(company.BusinessAreaCompanies)
            };

            questionnaireService.MakeQuestionnaire(companyDTO);

            return "Регистрация прошла успешно. Спасибо.";
        }
    }
}