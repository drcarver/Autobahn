//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityFinanceView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityFinanceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityFinanceView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilityFinance View Model as the data context for the view
        /// </summary>
        public FacilityFinanceView(Interfaces.IFacilityFinance vm)
        {
            BindingContext  = vm;
        }
    }
}
