//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityLocationView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityLocationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityLocationView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilityLocationViewModel as the data context for the view
        /// </summary>
        public FacilityLocationView(IFacilityLocationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
