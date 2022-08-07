//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramMeetingAttendeeView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IndividualizedProgramMeetingAttendeeView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramMeetingAttendeeView : ContentPage
    {
        /// <summary>
        /// Inject the IIndividualizedProgramMeetingAttendeeViewModel as the data context for the view
        /// </summary>
        public IndividualizedProgramMeetingAttendeeView(IIndividualizedProgramMeetingAttendeeViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
