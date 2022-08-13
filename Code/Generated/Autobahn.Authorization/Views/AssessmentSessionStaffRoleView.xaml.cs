//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentSessionStaffRoleView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentSessionStaffRoleView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentSessionStaffRoleView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentSessionStaffRole View Model as the data context for the view
        /// </summary>
        public AssessmentSessionStaffRoleView(Interfaces.IAssessmentSessionStaffRole vm)
        {
            BindingContext  = vm;
        }
    }
}
