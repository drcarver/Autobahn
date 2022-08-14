//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAdministrationOrganizationView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentAdministrationOrganizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentAdministrationOrganizationView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentAdministrationOrganization View Model as the data context for the view
        /// </summary>
        public AssessmentAdministrationOrganizationView(Interfaces.IAssessmentAdministrationOrganization vm)
        {
            BindingContext  = vm;
        }
    }
}
