//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationNeglectedView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ProgramParticipationNeglectedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationNeglectedView : ContentPage
    {
        /// <summary>
        /// Inject the ProgramParticipationNeglectedViewModel as the data context for the view
        /// </summary>
        public ProgramParticipationNeglectedView(ProgramParticipationNeglectedViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
