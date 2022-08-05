//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityLeaseView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityLeaseView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityLeaseView : ContentPage
    {
        /// <summary>
        /// Inject the FacilityLeaseViewModel as the data context for the view
        /// </summary>
        public FacilityLeaseView(FacilityLeaseViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}