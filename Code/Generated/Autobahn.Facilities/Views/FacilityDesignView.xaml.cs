//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityDesignView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityDesignView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityDesignView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilityDesign View Model as the data context for the view
        /// </summary>
        public FacilityDesignView(Interfaces.IFacilityDesign vm)
        {
            BindingContext  = vm;
        }
    }
}
