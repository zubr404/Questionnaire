using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Questionnaire.DAL.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public ICollection<Company> Companies { get; set; }
        public User()
        {
            Companies = new List<Company>();
        }
    }
}
