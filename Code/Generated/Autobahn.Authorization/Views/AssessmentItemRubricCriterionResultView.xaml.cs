//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentItemRubricCriterionResultView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentItemRubricCriterionResultView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentItemRubricCriterionResultView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentItemRubricCriterionResult View Model as the data context for the view
        /// </summary>
        public AssessmentItemRubricCriterionResultView(Interfaces.IAssessmentItemRubricCriterionResult vm)
        {
            BindingContext  = vm;
        }
    }
}
