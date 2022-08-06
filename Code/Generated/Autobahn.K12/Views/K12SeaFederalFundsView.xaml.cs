//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SeaFederalFundsView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12SeaFederalFundsView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12SeaFederalFundsView : ContentPage
    {
        /// <summary>
        /// Inject the K12SeaFederalFundsViewModel as the data context for the view
        /// </summary>
        public K12SeaFederalFundsView(K12SeaFederalFundsViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
