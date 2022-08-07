//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentAdministration_OrganizationView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentAdministration_OrganizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentAdministration_OrganizationView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentAdministration_OrganizationViewModel as the data context for the view
        /// </summary>
        public AssessmentAdministration_OrganizationView(IAssessmentAdministration_OrganizationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
