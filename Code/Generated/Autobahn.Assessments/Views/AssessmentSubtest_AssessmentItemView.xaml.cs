//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtest_AssessmentItemView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentSubtest_AssessmentItemView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentSubtest_AssessmentItemView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentSubtest_AssessmentItem View Model as the data context for the view
        /// </summary>
        public AssessmentSubtest_AssessmentItemView(Interfaces.IAssessmentSubtest_AssessmentItem vm)
        {
            BindingContext  = vm;
        }
    }
}
