//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityEnergyView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityEnergyView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityEnergyView : ContentPage
    {
        /// <summary>
        /// Inject the FacilityEnergyViewModel as the data context for the view
        /// </summary>
        public FacilityEnergyView(FacilityEnergyViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
