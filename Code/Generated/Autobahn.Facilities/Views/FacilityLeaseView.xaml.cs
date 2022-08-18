//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityLeaseView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityLeaseView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityLeaseView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilityLease View Model as the data context for the view
        /// </summary>
        public FacilityLeaseView(Interfaces.IFacilityLease vm)
        {
            BindingContext  = vm;
        }
    }
}
