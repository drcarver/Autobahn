//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationTitleIView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ProgramParticipationTitleIView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationTitleIView : ContentPage
    {
        /// <summary>
        /// Inject the ProgramParticipationTitleIViewModel as the data context for the view
        /// </summary>
        public ProgramParticipationTitleIView(ProgramParticipationTitleIViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
