//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityAuditView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityAuditView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityAuditView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilityAudit View Model as the data context for the view
        /// </summary>
        public FacilityAuditView(Interfaces.IFacilityAudit vm)
        {
            BindingContext  = vm;
        }
    }
}
