//**********************************************************
//* DomainName: Autobahn.Workforce
//* FileName:   WorkforceProgramParticipationView.cs
//**********************************************************

using Autobahn.Workforce.ViewModels;

namespace Autobahn.Workforce.Views
{
     /// <summary>
     /// The WorkforceProgramParticipationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkforceProgramParticipationView : ContentPage
    {
        /// <summary>
        /// Inject the IWorkforceProgramParticipationViewModel as the data context for the view
        /// </summary>
        public WorkforceProgramParticipationView(IWorkforceProgramParticipationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
