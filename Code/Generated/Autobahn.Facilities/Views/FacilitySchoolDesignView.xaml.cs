//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilitySchoolDesignView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilitySchoolDesignView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilitySchoolDesignView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilitySchoolDesignViewModel as the data context for the view
        /// </summary>
        public FacilitySchoolDesignView(IFacilitySchoolDesignViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
