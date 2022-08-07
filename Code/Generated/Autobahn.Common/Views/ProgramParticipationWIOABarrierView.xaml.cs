//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationWIOABarrierView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ProgramParticipationWIOABarrierView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationWIOABarrierView : ContentPage
    {
        /// <summary>
        /// Inject the IProgramParticipationWIOABarrierViewModel as the data context for the view
        /// </summary>
        public ProgramParticipationWIOABarrierView(IProgramParticipationWIOABarrierViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
