//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityMortgageView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityMortgageView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityMortgageView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilityMortgage View Model as the data context for the view
        /// </summary>
        public FacilityMortgageView(Interfaces.IFacilityMortgage vm)
        {
            BindingContext  = vm;
        }
    }
}
