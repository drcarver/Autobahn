//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ServiceProvidedView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ServiceProvidedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServiceProvidedView : ContentPage
    {
        /// <summary>
        /// Inject the IServiceProvidedViewModel as the data context for the view
        /// </summary>
        public ServiceProvidedView(IServiceProvidedViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
