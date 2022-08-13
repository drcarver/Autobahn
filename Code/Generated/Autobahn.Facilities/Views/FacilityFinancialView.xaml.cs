//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityFinancialView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityFinancialView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityFinancialView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilityFinancial View Model as the data context for the view
        /// </summary>
        public FacilityFinancialView(Interfaces.IFacilityFinancial vm)
        {
            BindingContext  = vm;
        }
    }
}
