//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonAddressView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonAddressView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonAddressView : ContentPage
    {
        /// <summary>
        /// Inject the PersonAddressViewModel as the data context for the view
        /// </summary>
        public PersonAddressView(PersonAddressViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
