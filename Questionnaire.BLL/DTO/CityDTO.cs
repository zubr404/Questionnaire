namespace Questionnaire.BLL.DTO
{
    public class CityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int RegionId { get; set; }
        public RegionDTO Region { get; set; }
    }
}
