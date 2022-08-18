//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonHealthBirthView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonHealthBirthView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonHealthBirthView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonHealthBirth View Model as the data context for the view
        /// </summary>
        public PersonHealthBirthView(Interfaces.IPersonHealthBirth vm)
        {
            BindingContext  = vm;
        }
    }
}
