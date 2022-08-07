//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   LocationAddressView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The LocationAddressView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocationAddressView : ContentPage
    {
        /// <summary>
        /// Inject the ILocationAddressViewModel as the data context for the view
        /// </summary>
        public LocationAddressView(ILocationAddressViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
