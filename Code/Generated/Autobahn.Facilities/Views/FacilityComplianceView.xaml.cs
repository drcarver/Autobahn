//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityComplianceView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityComplianceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityComplianceView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilityCompliance View Model as the data context for the view
        /// </summary>
        public FacilityComplianceView(Interfaces.IFacilityCompliance vm)
        {
            BindingContext  = vm;
        }
    }
}
