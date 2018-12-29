using System.Collections.Generic;
using Questionnaire.DAL.Entities;
using Questionnaire.DAL.Interfaces;
using Questionnaire.Models;

namespace Questionnaire.DAL.Repositories
{
    class CompanyRepository : IRepository<Company>
    {
        private QuestionnaireContext db;

        public CompanyRepository(QuestionnaireContext context)
        {
            db = context;
        }

        public void Create(Company item)
        {
            db.Companies.Add(item);
        }

        public Company Get(int id)
        {
            return db.Companies.Find(id);
        }

        public IEnumerable<Company> GetAll()
        {
            return db.Companies;
        }
    }
}
