//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   LocationView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The LocationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocationView : ContentPage
    {
        /// <summary>
        /// Inject the ILocation View Model as the data context for the view
        /// </summary>
        public LocationView(Interfaces.ILocation vm)
        {
            BindingContext  = vm;
        }
    }
}
