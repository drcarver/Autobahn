//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ServiceProviderView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The ServiceProviderView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServiceProviderView : ContentPage
    {
        /// <summary>
        /// Inject the IServiceProvider View Model as the data context for the view
        /// </summary>
        public ServiceProviderView(Interfaces.IServiceProvider vm)
        {
            BindingContext  = vm;
        }
    }
}
