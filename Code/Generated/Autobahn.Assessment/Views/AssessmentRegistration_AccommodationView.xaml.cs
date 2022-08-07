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
        /// Inject the IAssessmentRegistration_AccommodationViewModel as the data context for the view
        /// </summary>
        public AssessmentRegistration_AccommodationView(IAssessmentRegistration_AccommodationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
