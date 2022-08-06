//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityDesignView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityDesignView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityDesignView : ContentPage
    {
        /// <summary>
        /// Inject the FacilityDesignViewModel as the data context for the view
        /// </summary>
        public FacilityDesignView(FacilityDesignViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
