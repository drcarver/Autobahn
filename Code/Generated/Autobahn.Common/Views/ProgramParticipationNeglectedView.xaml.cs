//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationNeglectedView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ProgramParticipationNeglectedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationNeglectedView : ContentPage
    {
        /// <summary>
        /// Inject the IProgramParticipationNeglected View Model as the data context for the view
        /// </summary>
        public ProgramParticipationNeglectedView(Interfaces.IProgramParticipationNeglected vm)
        {
            BindingContext  = vm;
        }
    }
}
