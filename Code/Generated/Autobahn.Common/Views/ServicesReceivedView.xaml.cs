//**********************************************************
//* DomainName: Common Models
//* FileName:   ServicesReceivedView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ServicesReceivedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServicesReceivedView : ContentPage
    {
        /// <summary>
        /// Inject the IServicesReceived View Model as the data context for the view
        /// </summary>
        public ServicesReceivedView(Interfaces.IServicesReceived vm)
        {
            BindingContext  = vm;
        }
    }
}
