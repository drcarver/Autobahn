//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonAddressNcesSideView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonAddressNcesSideView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonAddressNcesSideView : ContentPage
    {
        /// <summary>
        /// Inject the PersonAddressNcesSideViewModel as the data context for the view
        /// </summary>
        public PersonAddressNcesSideView(PersonAddressNcesSideViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
