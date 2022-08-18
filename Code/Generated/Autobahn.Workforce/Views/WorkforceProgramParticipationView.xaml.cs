//**********************************************************
//* DomainName: Workforce
//* FileName:   WorkforceProgramParticipationView.cs
//**********************************************************

namespace Autobahn.Workforce.Views
{
     /// <summary>
     /// The WorkforceProgramParticipationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkforceProgramParticipationView : ContentPage
    {
        /// <summary>
        /// Inject the IWorkforceProgramParticipation View Model as the data context for the view
        /// </summary>
        public WorkforceProgramParticipationView(Interfaces.IWorkforceProgramParticipation vm)
        {
            BindingContext  = vm;
        }
    }
}
