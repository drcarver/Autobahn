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
        /// Inject the IProgramParticipationNeglectedViewModel as the data context for the view
        /// </summary>
        public ProgramParticipationNeglectedView(IProgramParticipationNeglectedViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
