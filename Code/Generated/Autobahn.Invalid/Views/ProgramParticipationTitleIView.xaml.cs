//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationTitleIView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The ProgramParticipationTitleIView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationTitleIView : ContentPage
    {
        /// <summary>
        /// Inject the IProgramParticipationTitleI View Model as the data context for the view
        /// </summary>
        public ProgramParticipationTitleIView(Interfaces.IProgramParticipationTitleI vm)
        {
            BindingContext  = vm;
        }
    }
}
