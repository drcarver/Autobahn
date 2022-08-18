//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramMeetingView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IndividualizedProgramMeetingView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramMeetingView : ContentPage
    {
        /// <summary>
        /// Inject the IIndividualizedProgramMeeting View Model as the data context for the view
        /// </summary>
        public IndividualizedProgramMeetingView(Interfaces.IIndividualizedProgramMeeting vm)
        {
            BindingContext  = vm;
        }
    }
}
