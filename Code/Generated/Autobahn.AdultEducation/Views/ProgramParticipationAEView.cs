//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   ProgramParticipationAEView.cs
//**********************************************************

using Autobahn.AdultEducation.ViewModels;

namespace Autobahn.AdultEducation.Views
{
     /// <summary>
     /// The ProgramParticipationAEView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationAEView : ContentPage
    {
        /// <summary>
        /// Inject the ProgramParticipationAEViewModel as the data context for the view
        /// </summary>
        public ProgramParticipationAEView(ProgramParticipationAEViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
