//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormSectionAssessmentItemView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentFormSectionAssessmentItemView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentFormSectionAssessmentItemView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentFormSectionAssessmentItem View Model as the data context for the view
        /// </summary>
        public AssessmentFormSectionAssessmentItemView(Interfaces.IAssessmentFormSectionAssessmentItem vm)
        {
            BindingContext  = vm;
        }
    }
}
