using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<BusinessArea> GetPart(int id)
        {
            return db.BusinessAreas.Where(x => x.Id == id);
        }
    }
}
