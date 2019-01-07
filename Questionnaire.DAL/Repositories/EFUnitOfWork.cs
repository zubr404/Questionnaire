using Questionnaire.DAL.Entities;
using Questionnaire.DAL.Interfaces;
using Questionnaire.Models;
using System;

namespace Questionnaire.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private QuestionnaireContext db;
        private BusinessAreaCompanyRepository businessAreaCompanyRepository;
        private BusinessAreaRepository businessAreaRepository;
        private CityRepository cityRepository;
        private CompanyRepository companyRepository;
        private RegionRepository regionRepository;

        public EFUnitOfWork (string connectionString)
        {
            db = new QuestionnaireContext(connectionString);
        }

        public IRepository<BusinessArea> BusinessArea => businessAreaRepository ?? (businessAreaRepository = new BusinessAreaRepository(db));
        public IRepository<BusinessAreaCompany> BusinessAreaCompany => businessAreaCompanyRepository ?? (businessAreaCompanyRepository = new BusinessAreaCompanyRepository(db));
        public IRepository<City> City => cityRepository ?? (cityRepository = new CityRepository(db));
        public IRepository<Company> Company => companyRepository ?? (companyRepository = new CompanyRepository(db));
        public IRepository<Region> Region => regionRepository ?? (regionRepository = new RegionRepository(db));

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
