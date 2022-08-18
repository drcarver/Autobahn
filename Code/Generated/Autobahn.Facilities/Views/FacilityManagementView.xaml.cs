//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityManagementView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityManagementView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityManagementView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilityManagement View Model as the data context for the view
        /// </summary>
        public FacilityManagementView(Interfaces.IFacilityManagement vm)
        {
            BindingContext  = vm;
        }
    }
}
