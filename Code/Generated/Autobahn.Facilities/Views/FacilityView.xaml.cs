//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityView : ContentPage
    {
        /// <summary>
        /// Inject the IFacility View Model as the data context for the view
        /// </summary>
        public FacilityView(Interfaces.IFacility vm)
        {
            BindingContext  = vm;
        }
    }
}
