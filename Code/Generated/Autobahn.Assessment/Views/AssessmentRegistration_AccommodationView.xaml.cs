//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentRegistration_AccommodationView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentRegistration_AccommodationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentRegistration_AccommodationView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentRegistration_AccommodationViewModel as the data context for the view
        /// </summary>
        public AssessmentRegistration_AccommodationView(AssessmentRegistration_AccommodationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
