//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonMilitaryView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonMilitaryView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonMilitaryView : ContentPage
    {
        /// <summary>
        /// Inject the PersonMilitaryViewModel as the data context for the view
        /// </summary>
        public PersonMilitaryView(PersonMilitaryViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
