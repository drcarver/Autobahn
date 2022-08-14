//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAdministration_OrganizationView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentAdministration_OrganizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentAdministration_OrganizationView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentAdministration_Organization View Model as the data context for the view
        /// </summary>
        public AssessmentAdministration_OrganizationView(Interfaces.IAssessmentAdministration_Organization vm)
        {
            BindingContext  = vm;
        }
    }
}
