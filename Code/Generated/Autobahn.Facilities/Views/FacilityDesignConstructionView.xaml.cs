//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityDesignConstructionView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityDesignConstructionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityDesignConstructionView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilityDesignConstruction View Model as the data context for the view
        /// </summary>
        public FacilityDesignConstructionView(Interfaces.IFacilityDesignConstruction vm)
        {
            BindingContext  = vm;
        }
    }
}
