//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IndividualizedProgramMeetingAttendeeView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The IndividualizedProgramMeetingAttendeeView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramMeetingAttendeeView : ContentPage
    {
        /// <summary>
        /// Inject the IIndividualizedProgramMeetingAttendee View Model as the data context for the view
        /// </summary>
        public IndividualizedProgramMeetingAttendeeView(Interfaces.IIndividualizedProgramMeetingAttendee vm)
        {
            BindingContext  = vm;
        }
    }
}
