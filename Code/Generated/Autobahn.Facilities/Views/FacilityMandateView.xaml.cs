//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityMandateView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityMandateView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityMandateView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilityMandate View Model as the data context for the view
        /// </summary>
        public FacilityMandateView(Interfaces.IFacilityMandate vm)
        {
            BindingContext  = vm;
        }
    }
}
