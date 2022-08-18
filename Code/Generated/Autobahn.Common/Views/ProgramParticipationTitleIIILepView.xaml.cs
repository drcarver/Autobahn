//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationTitleIiiLepView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ProgramParticipationTitleIiiLepView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationTitleIiiLepView : ContentPage
    {
        /// <summary>
        /// Inject the IProgramParticipationTitleIiiLep View Model as the data context for the view
        /// </summary>
        public ProgramParticipationTitleIiiLepView(Interfaces.IProgramParticipationTitleIiiLep vm)
        {
            BindingContext  = vm;
        }
    }
}
