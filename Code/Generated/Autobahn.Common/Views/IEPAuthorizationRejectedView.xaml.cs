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
        /// Inject the IEPAuthorizationRejectedViewModel as the data context for the view
        /// </summary>
        public IEPAuthorizationRejectedView(IEPAuthorizationRejectedViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
