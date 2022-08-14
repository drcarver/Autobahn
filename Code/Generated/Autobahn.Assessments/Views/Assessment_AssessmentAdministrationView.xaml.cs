//**********************************************************
//* DomainName: Assessments
//* FileName:   Assessment_AssessmentAdministrationView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The Assessment_AssessmentAdministrationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Assessment_AssessmentAdministrationView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessment_AssessmentAdministration View Model as the data context for the view
        /// </summary>
        public Assessment_AssessmentAdministrationView(Interfaces.IAssessment_AssessmentAdministration vm)
        {
            BindingContext  = vm;
        }
    }
}
