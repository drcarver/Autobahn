//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationWIOABarrierView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The ProgramParticipationWIOABarrierView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationWIOABarrierView : ContentPage
    {
        /// <summary>
        /// Inject the IProgramParticipationWIOABarrier View Model as the data context for the view
        /// </summary>
        public ProgramParticipationWIOABarrierView(Interfaces.IProgramParticipationWIOABarrier vm)
        {
            BindingContext  = vm;
        }
    }
}
