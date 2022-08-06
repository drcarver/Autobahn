//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityFinancialView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityFinancialView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityFinancialView : ContentPage
    {
        /// <summary>
        /// Inject the FacilityFinancialViewModel as the data context for the view
        /// </summary>
        public FacilityFinancialView(FacilityFinancialViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
