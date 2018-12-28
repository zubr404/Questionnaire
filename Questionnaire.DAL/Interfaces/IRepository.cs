using System.Collections.Generic;

namespace Questionnaire.DAL.Interfaces
{
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Create(T item);
    }
}
