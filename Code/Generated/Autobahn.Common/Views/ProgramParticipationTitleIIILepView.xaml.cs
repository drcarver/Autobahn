//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationTitleIIILepView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ProgramParticipationTitleIIILepView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationTitleIIILepView : ContentPage
    {
        /// <summary>
        /// Inject the ProgramParticipationTitleIIILepViewModel as the data context for the view
        /// </summary>
        public ProgramParticipationTitleIIILepView(ProgramParticipationTitleIIILepViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
