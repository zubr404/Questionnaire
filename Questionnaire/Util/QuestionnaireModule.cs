using Ninject.Modules;
using Questionnaire.BLL.Interfaces;
using Questionnaire.BLL.Services;

namespace Questionnaire.Util
{
    public class QuestionnaireModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IQuestionnaireService>().To<QuestionnaireService>();
        }
    }
}