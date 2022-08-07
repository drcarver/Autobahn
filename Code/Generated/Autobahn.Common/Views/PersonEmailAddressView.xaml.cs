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
        /// Inject the IPersonEmailAddressViewModel as the data context for the view
        /// </summary>
        public PersonEmailAddressView(IPersonEmailAddressViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
