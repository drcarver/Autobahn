//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityView : ContentPage
    {
        /// <summary>
        /// Inject the FacilityViewModel as the data context for the view
        /// </summary>
        public FacilityView(FacilityViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
