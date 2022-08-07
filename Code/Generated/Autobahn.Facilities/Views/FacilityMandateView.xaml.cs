//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityMandateView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityMandateView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityMandateView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilityMandateViewModel as the data context for the view
        /// </summary>
        public FacilityMandateView(IFacilityMandateViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
