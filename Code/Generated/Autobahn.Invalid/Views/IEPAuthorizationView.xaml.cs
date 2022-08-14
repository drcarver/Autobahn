//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IEPAuthorizationView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The IEPAuthorizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IEPAuthorizationView : ContentPage
    {
        /// <summary>
        /// Inject the IIEPAuthorization View Model as the data context for the view
        /// </summary>
        public IEPAuthorizationView(Interfaces.IIEPAuthorization vm)
        {
            BindingContext  = vm;
        }
    }
}
