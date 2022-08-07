//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   LocationView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The LocationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocationView : ContentPage
    {
        /// <summary>
        /// Inject the ILocationViewModel as the data context for the view
        /// </summary>
        public LocationView(ILocationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
