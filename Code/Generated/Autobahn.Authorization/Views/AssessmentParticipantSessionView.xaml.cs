//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentParticipantSessionView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentParticipantSessionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentParticipantSessionView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentParticipantSession View Model as the data context for the view
        /// </summary>
        public AssessmentParticipantSessionView(Interfaces.IAssessmentParticipantSession vm)
        {
            BindingContext  = vm;
        }
    }
}
