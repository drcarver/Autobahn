//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityUtilizationView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityUtilizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityUtilizationView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilityUtilization View Model as the data context for the view
        /// </summary>
        public FacilityUtilizationView(Interfaces.IFacilityUtilization vm)
        {
            BindingContext  = vm;
        }
    }
}
