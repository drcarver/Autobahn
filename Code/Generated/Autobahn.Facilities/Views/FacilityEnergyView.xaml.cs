//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityEnergyView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityEnergyView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityEnergyView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilityEnergy View Model as the data context for the view
        /// </summary>
        public FacilityEnergyView(Interfaces.IFacilityEnergy vm)
        {
            BindingContext  = vm;
        }
    }
}
