//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityManagementPlanView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityManagementPlanView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityManagementPlanView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilityManagementPlan View Model as the data context for the view
        /// </summary>
        public FacilityManagementPlanView(Interfaces.IFacilityManagementPlan vm)
        {
            BindingContext  = vm;
        }
    }
}
