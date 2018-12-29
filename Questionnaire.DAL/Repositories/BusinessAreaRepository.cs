using System.Collections.Generic;
using Questionnaire.DAL.Entities;
using Questionnaire.DAL.Interfaces;
using Questionnaire.Models;

namespace Questionnaire.DAL.Repositories
{
    class BusinessAreaRepository : IRepository<BusinessArea>
    {
        private QuestionnaireContext db;

        public BusinessAreaRepository(QuestionnaireContext context)
        {
            db = context;
        }

        public void Create(BusinessArea item)
        {
            
        }

        public BusinessArea Get(int id)
        {
            return db.BusinessAreas.Find(id);
        }

        public IEnumerable<BusinessArea> GetAll()
        {
            return db.BusinessAreas;
        }
    }
}
