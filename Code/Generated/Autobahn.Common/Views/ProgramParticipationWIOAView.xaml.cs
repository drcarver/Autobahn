//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationWIOAView.cs
//**********************************************************

namespace Autobahn.Common.Views
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
