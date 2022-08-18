//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationWIOABarriersView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ProgramParticipationWIOABarriersView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationWIOABarriersView : ContentPage
    {
        /// <summary>
        /// Inject the IProgramParticipationWIOABarriers View Model as the data context for the view
        /// </summary>
        public ProgramParticipationWIOABarriersView(Interfaces.IProgramParticipationWIOABarriers vm)
        {
            BindingContext  = vm;
        }
    }
}
