//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentParticipantSessionAccommodationView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentParticipantSessionAccommodationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentParticipantSessionAccommodationView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentParticipantSessionAccommodation View Model as the data context for the view
        /// </summary>
        public AssessmentParticipantSessionAccommodationView(Interfaces.IAssessmentParticipantSessionAccommodation vm)
        {
            BindingContext  = vm;
        }
    }
}
