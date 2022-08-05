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
        /// Inject the LocationViewModel as the data context for the view
        /// </summary>
        public LocationView(LocationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
