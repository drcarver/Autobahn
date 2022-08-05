//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonProgramParticipationView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonProgramParticipationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonProgramParticipationView : ContentPage
    {
        /// <summary>
        /// Inject the PersonProgramParticipationViewModel as the data context for the view
        /// </summary>
        public PersonProgramParticipationView(PersonProgramParticipationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}