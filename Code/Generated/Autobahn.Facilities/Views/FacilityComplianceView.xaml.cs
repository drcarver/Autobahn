//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityComplianceView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityComplianceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityComplianceView : ContentPage
    {
        /// <summary>
        /// Inject the FacilityComplianceViewModel as the data context for the view
        /// </summary>
        public FacilityComplianceView(FacilityComplianceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
