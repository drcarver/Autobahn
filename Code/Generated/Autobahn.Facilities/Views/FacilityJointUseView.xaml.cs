//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityJointUseView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityJointUseView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityJointUseView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilityJointUseViewModel as the data context for the view
        /// </summary>
        public FacilityJointUseView(IFacilityJointUseViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
