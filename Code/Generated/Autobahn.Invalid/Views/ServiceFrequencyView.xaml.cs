//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ServiceFrequencyView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The ServiceFrequencyView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServiceFrequencyView : ContentPage
    {
        /// <summary>
        /// Inject the IServiceFrequency View Model as the data context for the view
        /// </summary>
        public ServiceFrequencyView(Interfaces.IServiceFrequency vm)
        {
            BindingContext  = vm;
        }
    }
}
