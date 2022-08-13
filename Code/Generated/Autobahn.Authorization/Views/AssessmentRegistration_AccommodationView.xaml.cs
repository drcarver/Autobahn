//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentRegistration_AccommodationView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentRegistration_AccommodationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentRegistration_AccommodationView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentRegistration_Accommodation View Model as the data context for the view
        /// </summary>
        public AssessmentRegistration_AccommodationView(Interfaces.IAssessmentRegistration_Accommodation vm)
        {
            BindingContext  = vm;
        }
    }
}
