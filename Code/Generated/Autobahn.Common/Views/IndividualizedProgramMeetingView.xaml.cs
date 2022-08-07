//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramMeetingView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IndividualizedProgramMeetingView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramMeetingView : ContentPage
    {
        /// <summary>
        /// Inject the IIndividualizedProgramMeetingViewModel as the data context for the view
        /// </summary>
        public IndividualizedProgramMeetingView(IIndividualizedProgramMeetingViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
