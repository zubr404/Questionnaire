using System.Collections.Generic;
using System.Linq;
using Questionnaire.DAL.Entities;
using Questionnaire.DAL.Interfaces;
using Questionnaire.Models;

namespace Questionnaire.DAL.Repositories
{
    class RegionRepository : IRepository<Region>
    {
        private QuestionnaireContext db;

        public RegionRepository(QuestionnaireContext context)
        {
            db = context;
        }

        public void Create(Region item)
        {
            
        }

        public Region Get(int id)
        {
            return db.Regions.Find(id);
        }

        public IEnumerable<Region> GetAll()
        {
            return db.Regions;
        }

        public IEnumerable<Region> GetPart(int id)
        {
            return db.Regions.Where(x => x.Id == id);
        }
    }
}
