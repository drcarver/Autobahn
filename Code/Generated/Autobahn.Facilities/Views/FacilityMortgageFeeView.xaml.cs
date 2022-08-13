//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityMortgageFeeView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityMortgageFeeView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityMortgageFeeView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilityMortgageFee View Model as the data context for the view
        /// </summary>
        public FacilityMortgageFeeView(Interfaces.IFacilityMortgageFee vm)
        {
            BindingContext  = vm;
        }
    }
}
