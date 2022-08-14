//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramMeetingAttendeeView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
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
