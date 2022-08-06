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
        /// Inject the FacilityManagementPlanViewModel as the data context for the view
        /// </summary>
        public FacilityManagementPlanView(FacilityManagementPlanViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
