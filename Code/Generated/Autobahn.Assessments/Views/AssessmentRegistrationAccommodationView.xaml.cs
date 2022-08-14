//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentRegistrationAccommodationView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentRegistrationAccommodationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentRegistrationAccommodationView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentRegistrationAccommodation View Model as the data context for the view
        /// </summary>
        public AssessmentRegistrationAccommodationView(Interfaces.IAssessmentRegistrationAccommodation vm)
        {
            BindingContext  = vm;
        }
    }
}
