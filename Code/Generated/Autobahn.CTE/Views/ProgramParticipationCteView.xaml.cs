//**********************************************************
//* DomainName: Career and Technical Education (CTE)
//* FileName:   ProgramParticipationCteView.cs
//**********************************************************

namespace Autobahn.CTE.Views
{
     /// <summary>
     /// The ProgramParticipationCteView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationCteView : ContentPage
    {
        /// <summary>
        /// Inject the IProgramParticipationCte View Model as the data context for the view
        /// </summary>
        public ProgramParticipationCteView(Interfaces.IProgramParticipationCte vm)
        {
            BindingContext  = vm;
        }
    }
}
