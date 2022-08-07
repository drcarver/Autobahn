//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemRubricCriterionResultView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentItemRubricCriterionResultView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentItemRubricCriterionResultView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentItemRubricCriterionResultViewModel as the data context for the view
        /// </summary>
        public AssessmentItemRubricCriterionResultView(IAssessmentItemRubricCriterionResultViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
