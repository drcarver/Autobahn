//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ServiceFrequencyView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ServiceFrequencyView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServiceFrequencyView : ContentPage
    {
        /// <summary>
        /// Inject the IServiceFrequencyViewModel as the data context for the view
        /// </summary>
        public ServiceFrequencyView(IServiceFrequencyViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
