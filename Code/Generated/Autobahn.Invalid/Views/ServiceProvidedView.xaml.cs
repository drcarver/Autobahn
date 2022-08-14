//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ServiceProvidedView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
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
