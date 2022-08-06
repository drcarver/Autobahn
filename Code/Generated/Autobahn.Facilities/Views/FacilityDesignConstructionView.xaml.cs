//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityDesignConstructionView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityDesignConstructionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityDesignConstructionView : ContentPage
    {
        /// <summary>
        /// Inject the FacilityDesignConstructionViewModel as the data context for the view
        /// </summary>
        public FacilityDesignConstructionView(FacilityDesignConstructionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
