using System.Collections.Generic;
using Questionnaire.DAL.Entities;
using Questionnaire.DAL.Interfaces;

namespace Questionnaire.DAL.Repositories
{
    class CompanyRepository : IRepository<Company>
    {
        public void Create(Company item)
        {
            throw new System.NotImplementedException();
        }

        public Company Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Company> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
