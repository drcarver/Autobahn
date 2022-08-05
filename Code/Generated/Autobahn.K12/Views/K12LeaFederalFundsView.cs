//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaFederalFundsView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12LeaFederalFundsView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12LeaFederalFundsView : ContentPage
    {
        /// <summary>
        /// Inject the K12LeaFederalFundsViewModel as the data context for the view
        /// </summary>
        public K12LeaFederalFundsView(K12LeaFederalFundsViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
