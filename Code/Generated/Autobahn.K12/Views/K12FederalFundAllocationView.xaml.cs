//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12FederalFundAllocationView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12FederalFundAllocationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12FederalFundAllocationView : ContentPage
    {
        /// <summary>
        /// Inject the IK12FederalFundAllocation View Model as the data context for the view
        /// </summary>
        public K12FederalFundAllocationView(Interfaces.IK12FederalFundAllocation vm)
        {
            BindingContext  = vm;
        }
    }
}
