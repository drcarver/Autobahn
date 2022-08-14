//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   LocationAddressView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The LocationAddressView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocationAddressView : ContentPage
    {
        /// <summary>
        /// Inject the ILocationAddress View Model as the data context for the view
        /// </summary>
        public LocationAddressView(Interfaces.ILocationAddress vm)
        {
            BindingContext  = vm;
        }
    }
}
