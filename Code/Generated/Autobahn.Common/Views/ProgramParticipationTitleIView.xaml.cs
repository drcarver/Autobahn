//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationTitleIView.cs
//**********************************************************

namespace Autobahn.Common.Views
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
