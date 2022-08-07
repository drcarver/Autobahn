//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityManagementPlanView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityManagementPlanView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityManagementPlanView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilityManagementPlanViewModel as the data context for the view
        /// </summary>
        public FacilityManagementPlanView(IFacilityManagementPlanViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
