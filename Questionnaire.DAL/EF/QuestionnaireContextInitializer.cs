using Questionnaire.DAL.Entities;
using System.Collections.Generic;
using System.Data.Entity;

namespace Questionnaire.Models
{
    public class QuestionnaireContextInitializer : DropCreateDatabaseAlways<QuestionnaireContext>
    {
        protected override void Seed(QuestionnaireContext context)
        {
            Region region1 = new Region() { Id = 1, Name = "Республика Адыгея" };
            Region region2 = new Region() { Id = 2, Name = "Республика Башкортостан" };

            context.Regions.Add(region1);
            context.Regions.Add(region2);
            context.SaveChanges();

            City city1 = new City() { Id = 1, Name = "Адыгейск", Region = region1 };
            City city2 = new City() { Id = 2, Name = "Майкоп", Region = region1 };

            City city3 = new City() { Id = 1, Name = "Уфа", Region = region2 };
            City city4 = new City() { Id = 2, Name = "Стерлитамак", Region = region2 };

            context.Cities.AddRange(new List<City> { city1, city2, city3, city4 });
            context.SaveChanges();

            context.BusinessAreas.Add(new BusinessArea() { Id = 1, Name = "Одежда" });
            context.BusinessAreas.Add(new BusinessArea() { Id = 2, Name = "Обувь" });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}