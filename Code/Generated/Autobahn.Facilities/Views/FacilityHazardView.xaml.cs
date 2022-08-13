//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityHazardView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityHazardView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityHazardView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilityHazard View Model as the data context for the view
        /// </summary>
        public FacilityHazardView(Interfaces.IFacilityHazard vm)
        {
            BindingContext  = vm;
        }
    }
}
