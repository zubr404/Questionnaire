using System.ComponentModel.DataAnnotations;
namespace Questionnaire.DAL.Entities
{
    public class BusinessArea
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
