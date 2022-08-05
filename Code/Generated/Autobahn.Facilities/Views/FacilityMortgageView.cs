//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityMortgageView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityMortgageView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityMortgageView : ContentPage
    {
        /// <summary>
        /// Inject the FacilityMortgageViewModel as the data context for the view
        /// </summary>
        public FacilityMortgageView(FacilityMortgageViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
