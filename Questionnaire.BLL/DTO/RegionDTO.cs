using System.Collections.Generic;

namespace Questionnaire.BLL.DTO
{
    public class RegionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CityDTO> Cities { get; set; }
        public RegionDTO()
        {
            Cities = new List<CityDTO>();
        }
    }
}
