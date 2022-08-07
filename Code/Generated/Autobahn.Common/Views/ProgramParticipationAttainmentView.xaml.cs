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
        /// Inject the IProgramParticipationAttainmentViewModel as the data context for the view
        /// </summary>
        public ProgramParticipationAttainmentView(IProgramParticipationAttainmentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
