//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentParticipantSession_AccommodationView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentParticipantSession_AccommodationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentParticipantSession_AccommodationView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentParticipantSession_Accommodation View Model as the data context for the view
        /// </summary>
        public AssessmentParticipantSession_AccommodationView(Interfaces.IAssessmentParticipantSession_Accommodation vm)
        {
            BindingContext  = vm;
        }
    }
}
