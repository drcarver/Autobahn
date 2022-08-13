//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentAdministrationView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentAdministrationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentAdministrationView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentAdministration View Model as the data context for the view
        /// </summary>
        public AssessmentAdministrationView(Interfaces.IAssessmentAdministration vm)
        {
            BindingContext  = vm;
        }
    }
}
