//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProgramParticipationTitleIView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The ProgramParticipationTitleIView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationTitleIView : ContentPage
    {
        /// <summary>
        /// Inject the IProgramParticipationTitleI View Model as the data context for the view
        /// </summary>
        public ProgramParticipationTitleIView(Interfaces.IProgramParticipationTitleI vm)
        {
            BindingContext  = vm;
        }
    }
}
