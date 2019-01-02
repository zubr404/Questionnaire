using System.Collections.Generic;

namespace Questionnaire.DAL.Interfaces
{
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetPart(int id);
        T Get(int id);
        void Create(T item);
    }
}
