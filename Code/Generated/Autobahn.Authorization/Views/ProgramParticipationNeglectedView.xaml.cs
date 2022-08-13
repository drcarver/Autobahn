//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProgramParticipationNeglectedView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
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
