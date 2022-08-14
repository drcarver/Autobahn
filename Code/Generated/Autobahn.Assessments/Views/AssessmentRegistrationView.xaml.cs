//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentRegistrationView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentRegistrationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentRegistrationView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentRegistration View Model as the data context for the view
        /// </summary>
        public AssessmentRegistrationView(Interfaces.IAssessmentRegistration vm)
        {
            BindingContext  = vm;
        }
    }
}
