//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentParticipantSession_AccommodationView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentParticipantSession_AccommodationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentParticipantSession_AccommodationView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentParticipantSession_AccommodationViewModel as the data context for the view
        /// </summary>
        public AssessmentParticipantSession_AccommodationView(AssessmentParticipantSession_AccommodationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
