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
        /// Inject the IPEDSFinanceViewModel as the data context for the view
        /// </summary>
        public IPEDSFinanceView(IPEDSFinanceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
