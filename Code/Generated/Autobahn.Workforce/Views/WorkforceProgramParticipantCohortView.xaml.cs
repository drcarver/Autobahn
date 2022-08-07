//**********************************************************
//* DomainName: Autobahn.Workforce
//* FileName:   WorkforceProgramParticipantCohortView.cs
//**********************************************************

using Autobahn.Workforce.ViewModels;

namespace Autobahn.Workforce.Views
{
     /// <summary>
     /// The WorkforceProgramParticipantCohortView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkforceProgramParticipantCohortView : ContentPage
    {
        /// <summary>
        /// Inject the IWorkforceProgramParticipantCohortViewModel as the data context for the view
        /// </summary>
        public WorkforceProgramParticipantCohortView(IWorkforceProgramParticipantCohortViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
