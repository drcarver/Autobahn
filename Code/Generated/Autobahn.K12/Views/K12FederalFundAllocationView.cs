//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12FederalFundAllocationView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12FederalFundAllocationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12FederalFundAllocationView : ContentPage
    {
        /// <summary>
        /// Inject the K12FederalFundAllocationViewModel as the data context for the view
        /// </summary>
        public K12FederalFundAllocationView(K12FederalFundAllocationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
