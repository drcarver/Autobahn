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
        /// Inject the IProgramParticipationWIOAViewModel as the data context for the view
        /// </summary>
        public ProgramParticipationWIOAView(IProgramParticipationWIOAViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
