//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   IPEDSFinanceView.cs
//**********************************************************

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The IPEDSFinanceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IPEDSFinanceView : ContentPage
    {
        /// <summary>
        /// Inject the IIPEDSFinance View Model as the data context for the view
        /// </summary>
        public IPEDSFinanceView(Interfaces.IIPEDSFinance vm)
        {
            BindingContext  = vm;
        }
    }
}
