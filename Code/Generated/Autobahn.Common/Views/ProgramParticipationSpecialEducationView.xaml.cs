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
        /// Inject the IProgramParticipationSpecialEducationViewModel as the data context for the view
        /// </summary>
        public ProgramParticipationSpecialEducationView(IProgramParticipationSpecialEducationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
