//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ServiceProviderView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ServiceProviderView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServiceProviderView : ContentPage
    {
        /// <summary>
        /// Inject the ServiceProviderViewModel as the data context for the view
        /// </summary>
        public ServiceProviderView(ServiceProviderViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
