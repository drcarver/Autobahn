//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestAssessmentItemView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentSubtestAssessmentItemView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentSubtestAssessmentItemView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentSubtestAssessmentItem View Model as the data context for the view
        /// </summary>
        public AssessmentSubtestAssessmentItemView(Interfaces.IAssessmentSubtestAssessmentItem vm)
        {
            BindingContext  = vm;
        }
    }
}
