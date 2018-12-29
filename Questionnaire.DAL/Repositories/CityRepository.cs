using System.Collections.Generic;
using Questionnaire.DAL.Entities;
using Questionnaire.DAL.Interfaces;
using Questionnaire.Models;

namespace Questionnaire.DAL.Repositories
{
    class CityRepository : IRepository<City>
    {
        private QuestionnaireContext db;

        public CityRepository(QuestionnaireContext context)
        {
            db = context;
        }

        public void Create(City item)
        {
            db.Cities.Add(item);
        }

        public City Get(int id)
        {
            return db.Cities.Find(id);
        }

        public IEnumerable<City> GetAll()
        {
            return db.Cities;
        }
    }
}
