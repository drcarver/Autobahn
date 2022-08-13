//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProgramParticipationWIOAView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The ProgramParticipationWIOAView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationWIOAView : ContentPage
    {
        /// <summary>
        /// Inject the IProgramParticipationWIOA View Model as the data context for the view
        /// </summary>
        public ProgramParticipationWIOAView(Interfaces.IProgramParticipationWIOA vm)
        {
            BindingContext  = vm;
        }
    }
}
