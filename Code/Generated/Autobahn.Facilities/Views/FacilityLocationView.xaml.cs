//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityLocationView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityLocationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityLocationView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilityLocation View Model as the data context for the view
        /// </summary>
        public FacilityLocationView(Interfaces.IFacilityLocation vm)
        {
            BindingContext  = vm;
        }
    }
}
