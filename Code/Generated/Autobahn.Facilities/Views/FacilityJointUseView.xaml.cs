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
        /// Inject the FacilityJointUseViewModel as the data context for the view
        /// </summary>
        public FacilityJointUseView(FacilityJointUseViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
