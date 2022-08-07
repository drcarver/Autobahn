//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ServicesReceivedView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ServicesReceivedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServicesReceivedView : ContentPage
    {
        /// <summary>
        /// Inject the IServicesReceivedViewModel as the data context for the view
        /// </summary>
        public ServicesReceivedView(IServicesReceivedViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
