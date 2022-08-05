//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityAuditView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityAuditView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityAuditView : ContentPage
    {
        /// <summary>
        /// Inject the FacilityAuditViewModel as the data context for the view
        /// </summary>
        public FacilityAuditView(FacilityAuditViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
