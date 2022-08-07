//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentParticipantSessionView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentParticipantSessionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentParticipantSessionView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentParticipantSessionViewModel as the data context for the view
        /// </summary>
        public AssessmentParticipantSessionView(IAssessmentParticipantSessionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
