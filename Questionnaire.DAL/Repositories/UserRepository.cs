using System.Collections.Generic;
using Questionnaire.DAL.Entities;
using Questionnaire.DAL.Interfaces;
using Questionnaire.Models;

namespace Questionnaire.DAL.Repositories
{
    class UserRepository : IRepository<User>
    {
        private QuestionnaireContext db;

        public UserRepository(QuestionnaireContext context)
        {
            db = context;
        }

        public void Create(User item)
        {
            db.Users.Add(item);
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users;
        }
    }
}
