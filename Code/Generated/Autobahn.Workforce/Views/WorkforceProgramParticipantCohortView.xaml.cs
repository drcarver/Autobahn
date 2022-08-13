//**********************************************************
//* DomainName: Workforce
//* FileName:   WorkforceProgramParticipantCohortView.cs
//**********************************************************

namespace Autobahn.Workforce.Views
{
     /// <summary>
     /// The WorkforceProgramParticipantCohortView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkforceProgramParticipantCohortView : ContentPage
    {
        /// <summary>
        /// Inject the IWorkforceProgramParticipantCohort View Model as the data context for the view
        /// </summary>
        public WorkforceProgramParticipantCohortView(Interfaces.IWorkforceProgramParticipantCohort vm)
        {
            BindingContext  = vm;
        }
    }
}
