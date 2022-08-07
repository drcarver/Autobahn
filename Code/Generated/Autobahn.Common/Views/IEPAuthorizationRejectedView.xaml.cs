//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IEPAuthorizationRejectedView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IEPAuthorizationRejectedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IEPAuthorizationRejectedView : ContentPage
    {
        /// <summary>
        /// Inject the IIEPAuthorizationRejectedViewModel as the data context for the view
        /// </summary>
        public IEPAuthorizationRejectedView(IIEPAuthorizationRejectedViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
