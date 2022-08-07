//**********************************************************
//* DomainName: Autobahn.CareerandTechnical
//* FileName:   ProgramParticipationCteView.cs
//**********************************************************

using Autobahn.CareerandTechnical.ViewModels;

namespace Autobahn.CareerandTechnical.Views
{
     /// <summary>
     /// The ProgramParticipationCteView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationCteView : ContentPage
    {
        /// <summary>
        /// Inject the IProgramParticipationCteViewModel as the data context for the view
        /// </summary>
        public ProgramParticipationCteView(IProgramParticipationCteViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
