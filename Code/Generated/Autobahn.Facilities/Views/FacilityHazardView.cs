//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityHazardView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityHazardView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityHazardView : ContentPage
    {
        /// <summary>
        /// Inject the FacilityHazardViewModel as the data context for the view
        /// </summary>
        public FacilityHazardView(FacilityHazardViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
