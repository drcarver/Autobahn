//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityMortgageFeeView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityMortgageFeeView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityMortgageFeeView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilityMortgageFeeViewModel as the data context for the view
        /// </summary>
        public FacilityMortgageFeeView(IFacilityMortgageFeeViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
