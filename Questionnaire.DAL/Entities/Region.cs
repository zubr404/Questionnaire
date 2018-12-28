using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Questionnaire.DAL.Entities
{
    public class Region
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; }
        public Region()
        {
            Cities = new List<City>();
        }
    }
}
