//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityJointUseView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityJointUseView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityJointUseView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilityJointUse View Model as the data context for the view
        /// </summary>
        public FacilityJointUseView(Interfaces.IFacilityJointUse vm)
        {
            BindingContext  = vm;
        }
    }
}
