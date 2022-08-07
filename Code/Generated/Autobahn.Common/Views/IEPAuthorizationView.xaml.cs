//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IEPAuthorizationView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IEPAuthorizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IEPAuthorizationView : ContentPage
    {
        /// <summary>
        /// Inject the IIEPAuthorizationViewModel as the data context for the view
        /// </summary>
        public IEPAuthorizationView(IIEPAuthorizationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
