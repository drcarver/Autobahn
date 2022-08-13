//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   ProgramParticipationAEView.cs
//**********************************************************

namespace Autobahn.AdultEducation.Views
{
     /// <summary>
     /// The ProgramParticipationAEView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationAEView : ContentPage
    {
        /// <summary>
        /// Inject the IProgramParticipationAE View Model as the data context for the view
        /// </summary>
        public ProgramParticipationAEView(Interfaces.IProgramParticipationAE vm)
        {
            BindingContext  = vm;
        }
    }
}
