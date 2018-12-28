using System;
using Questionnaire.DAL.Entities;

namespace Questionnaire.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<BusinessArea> BusinessArea { get; }
        IRepository<BusinessAreaCompany> BusinessAreaCompany { get; }
        IRepository<City> City { get; }
        IRepository<Company> Company { get; }
        IRepository<Region> Region { get; }
        IRepository<User> User { get; }

        void Save();
    }
}
