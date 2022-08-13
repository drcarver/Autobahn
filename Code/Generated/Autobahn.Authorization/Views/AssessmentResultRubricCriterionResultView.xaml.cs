//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentResultRubricCriterionResultView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentResultRubricCriterionResultView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentResultRubricCriterionResultView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentResultRubricCriterionResult View Model as the data context for the view
        /// </summary>
        public AssessmentResultRubricCriterionResultView(Interfaces.IAssessmentResultRubricCriterionResult vm)
        {
            BindingContext  = vm;
        }
    }
}
