namespace Questionnaire.BLL.DTO
{
    public class BusinessAreaCompanyDTO
    {
        public int Id { get; set; }
        public int BusinessAreaId { get; set; }

        public int CompanyId { get; set; }
        public CompanyDTO Company { get; set; }
    }
}
