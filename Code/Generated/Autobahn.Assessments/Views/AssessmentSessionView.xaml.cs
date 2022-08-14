//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSessionView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentSessionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentSessionView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentSession View Model as the data context for the view
        /// </summary>
        public AssessmentSessionView(Interfaces.IAssessmentSession vm)
        {
            BindingContext  = vm;
        }
    }
}
