//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonHealthBirthView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonHealthBirthView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonHealthBirthView : ContentPage
    {
        /// <summary>
        /// Inject the PersonHealthBirthViewModel as the data context for the view
        /// </summary>
        public PersonHealthBirthView(PersonHealthBirthViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}