//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAssessmentAdministrationView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentAssessmentAdministrationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentAssessmentAdministrationView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentAssessmentAdministration View Model as the data context for the view
        /// </summary>
        public AssessmentAssessmentAdministrationView(Interfaces.IAssessmentAssessmentAdministration vm)
        {
            BindingContext  = vm;
        }
    }
}
