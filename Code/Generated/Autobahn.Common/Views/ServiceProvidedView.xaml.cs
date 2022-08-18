//**********************************************************
//* DomainName: Common Models
//* FileName:   ServiceProvidedView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ServiceProvidedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServiceProvidedView : ContentPage
    {
        /// <summary>
        /// Inject the IServiceProvided View Model as the data context for the view
        /// </summary>
        public ServiceProvidedView(Interfaces.IServiceProvided vm)
        {
            BindingContext  = vm;
        }
    }
}
