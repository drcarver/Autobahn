//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentRegistrationView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
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
