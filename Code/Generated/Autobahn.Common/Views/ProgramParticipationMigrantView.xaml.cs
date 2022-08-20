//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationMigrantView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ProgramParticipationMigrantView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationMigrantView : ContentPage
    {
        /// <summary>
        /// Inject the IProgramParticipationMigrant View Model as the data context for the view
        /// </summary>
        public ProgramParticipationMigrantView(Interfaces.IProgramParticipationMigrant vm)
        {
            BindingContext  = vm;
        }
    }
}