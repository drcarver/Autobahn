//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationWIOAView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ProgramParticipationWIOAView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationWIOAView : ContentPage
    {
        /// <summary>
        /// Inject the ProgramParticipationWIOAViewModel as the data context for the view
        /// </summary>
        public ProgramParticipationWIOAView(ProgramParticipationWIOAViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
