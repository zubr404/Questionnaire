using Questionnaire.Models;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Questionnaire
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            QuestionnaireContext context = new QuestionnaireContext();
            context.Database.Initialize(true);

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
