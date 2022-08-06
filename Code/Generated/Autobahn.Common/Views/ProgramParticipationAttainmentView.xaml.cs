//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationAttainmentView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ProgramParticipationAttainmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationAttainmentView : ContentPage
    {
        /// <summary>
        /// Inject the ProgramParticipationAttainmentViewModel as the data context for the view
        /// </summary>
        public ProgramParticipationAttainmentView(ProgramParticipationAttainmentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
