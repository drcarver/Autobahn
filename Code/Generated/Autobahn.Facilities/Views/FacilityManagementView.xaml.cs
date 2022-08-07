//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityManagementView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityManagementView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityManagementView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilityManagementViewModel as the data context for the view
        /// </summary>
        public FacilityManagementView(IFacilityManagementViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
