//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityUtilizationView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityUtilizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityUtilizationView : ContentPage
    {
        /// <summary>
        /// Inject the FacilityUtilizationViewModel as the data context for the view
        /// </summary>
        public FacilityUtilizationView(FacilityUtilizationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
