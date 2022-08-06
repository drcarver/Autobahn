//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationMigrantView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ProgramParticipationMigrantView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationMigrantView : ContentPage
    {
        /// <summary>
        /// Inject the ProgramParticipationMigrantViewModel as the data context for the view
        /// </summary>
        public ProgramParticipationMigrantView(ProgramParticipationMigrantViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
