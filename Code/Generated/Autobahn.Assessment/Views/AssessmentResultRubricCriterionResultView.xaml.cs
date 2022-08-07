//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentResultRubricCriterionResultView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentResultRubricCriterionResultView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentResultRubricCriterionResultView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentResultRubricCriterionResultViewModel as the data context for the view
        /// </summary>
        public AssessmentResultRubricCriterionResultView(IAssessmentResultRubricCriterionResultViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
