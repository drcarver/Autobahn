//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityFinanceView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityFinanceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityFinanceView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilityFinanceViewModel as the data context for the view
        /// </summary>
        public FacilityFinanceView(IFacilityFinanceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
