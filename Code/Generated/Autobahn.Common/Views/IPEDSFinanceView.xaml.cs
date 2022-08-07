//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPEDSFinanceView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IPEDSFinanceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IPEDSFinanceView : ContentPage
    {
        /// <summary>
        /// Inject the IIPEDSFinanceViewModel as the data context for the view
        /// </summary>
        public IPEDSFinanceView(IIPEDSFinanceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
