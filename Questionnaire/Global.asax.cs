using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;
using Questionnaire.BLL.Infrastructure;
using Questionnaire.Util;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Questionnaire.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // внедрение зависимостей
            NinjectModule questionnaireModule = new QuestionnaireModule();
            NinjectModule serviceModule = new ServiceModule("QuestionnaireContext");
            var kernel = new StandardKernel(questionnaireModule, serviceModule);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}
