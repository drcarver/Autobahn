//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IEPAuthorizationRejectedView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The IEPAuthorizationRejectedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IEPAuthorizationRejectedView : ContentPage
    {
        /// <summary>
        /// Inject the IIEPAuthorizationRejected View Model as the data context for the view
        /// </summary>
        public IEPAuthorizationRejectedView(Interfaces.IIEPAuthorizationRejected vm)
        {
            BindingContext  = vm;
        }
    }
}
