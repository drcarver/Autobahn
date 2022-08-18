//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SeaFederalFundAllocationView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12SeaFederalFundAllocationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12SeaFederalFundAllocationView : ContentPage
    {
        /// <summary>
        /// Inject the IK12SeaFederalFundAllocation View Model as the data context for the view
        /// </summary>
        public K12SeaFederalFundAllocationView(Interfaces.IK12SeaFederalFundAllocation vm)
        {
            BindingContext  = vm;
        }
    }
}
