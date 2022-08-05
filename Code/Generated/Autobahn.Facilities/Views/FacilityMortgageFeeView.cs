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
        /// Inject the FacilityMortgageFeeViewModel as the data context for the view
        /// </summary>
        public FacilityMortgageFeeView(FacilityMortgageFeeViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
