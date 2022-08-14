//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessment View Model as the data context for the view
        /// </summary>
        public AssessmentView(Interfaces.IAssessment vm)
        {
            BindingContext  = vm;
        }
    }
}
