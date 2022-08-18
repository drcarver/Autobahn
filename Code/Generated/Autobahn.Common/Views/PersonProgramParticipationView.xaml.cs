//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonProgramParticipationView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonProgramParticipationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonProgramParticipationView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonProgramParticipation View Model as the data context for the view
        /// </summary>
        public PersonProgramParticipationView(Interfaces.IPersonProgramParticipation vm)
        {
            BindingContext  = vm;
        }
    }
}
