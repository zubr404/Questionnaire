using System.Collections.Generic;

namespace Questionnaire.BLL.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public ICollection<CompanyDTO> Companies { get; set; }
        public UserDTO()
        {
            Companies = new List<CompanyDTO>();
        }
    }
}
