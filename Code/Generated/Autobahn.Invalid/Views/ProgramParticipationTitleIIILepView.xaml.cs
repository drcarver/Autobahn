//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationTitleIIILepView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The ProgramParticipationTitleIIILepView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationTitleIIILepView : ContentPage
    {
        /// <summary>
        /// Inject the IProgramParticipationTitleIIILep View Model as the data context for the view
        /// </summary>
        public ProgramParticipationTitleIIILepView(Interfaces.IProgramParticipationTitleIIILep vm)
        {
            BindingContext  = vm;
        }
    }
}
