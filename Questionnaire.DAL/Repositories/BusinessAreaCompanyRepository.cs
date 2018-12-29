using System.Collections.Generic;
using Questionnaire.DAL.Entities;
using Questionnaire.DAL.Interfaces;
using Questionnaire.Models;

namespace Questionnaire.DAL.Repositories
{
    class BusinessAreaCompanyRepository : IRepository<BusinessAreaCompany>
    {
        private QuestionnaireContext db;

        public BusinessAreaCompanyRepository(QuestionnaireContext context)
        {
            db = context;
        }

        public void Create(BusinessAreaCompany item)
        {
            db.BusinessAreaCompanies.Add(item);
        }

        public BusinessAreaCompany Get(int id)
        {
            return db.BusinessAreaCompanies.Find(id);
        }

        public IEnumerable<BusinessAreaCompany> GetAll()
        {
            return db.BusinessAreaCompanies;
        }
    }
}
