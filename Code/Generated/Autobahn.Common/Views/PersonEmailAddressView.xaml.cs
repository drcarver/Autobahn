//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonEmailAddressView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonEmailAddressView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonEmailAddressView : ContentPage
    {
        /// <summary>
        /// Inject the PersonEmailAddressViewModel as the data context for the view
        /// </summary>
        public PersonEmailAddressView(PersonEmailAddressViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
