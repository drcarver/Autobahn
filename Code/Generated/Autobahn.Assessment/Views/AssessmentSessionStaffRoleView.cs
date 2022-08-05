//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSessionStaffRoleView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentSessionStaffRoleView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentSessionStaffRoleView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentSessionStaffRoleViewModel as the data context for the view
        /// </summary>
        public AssessmentSessionStaffRoleView(AssessmentSessionStaffRoleViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
