//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationAttainmentView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ProgramParticipationAttainmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationAttainmentView : ContentPage
    {
        /// <summary>
        /// Inject the IProgramParticipationAttainment View Model as the data context for the view
        /// </summary>
        public ProgramParticipationAttainmentView(Interfaces.IProgramParticipationAttainment vm)
        {
            BindingContext  = vm;
        }
    }
}
