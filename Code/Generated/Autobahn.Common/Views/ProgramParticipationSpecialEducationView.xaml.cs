//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationSpecialEducationView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ProgramParticipationSpecialEducationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramParticipationSpecialEducationView : ContentPage
    {
        /// <summary>
        /// Inject the ProgramParticipationSpecialEducationViewModel as the data context for the view
        /// </summary>
        public ProgramParticipationSpecialEducationView(ProgramParticipationSpecialEducationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
